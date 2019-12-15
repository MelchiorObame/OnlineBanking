using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankOnline
{
    public partial class SendMoneyForm : Form
    {
        //Fields
        private string strReceiver;  // customer receiving money
        private double dblAmount;    // sending amount
        private string strCustomer;  // actual customer sending money
        private string strCustomerFilePath;   //location of customer.txt file

        public SendMoneyForm(string customer)
        {
            InitializeComponent();
            strCustomerFilePath = "../../../BankData/customers.txt";
            strCustomer = customer;
            fillUserNameToComboList();
            strReceiver = "";
            dblAmount = 0.0;
            this.ActiveControl = this.amountTextBox;    
        }

        //add all userNames to ComboBox
        private void fillUserNameToComboList()
        {
            //read customer.txt file
            string[] arrayCustomerInformations = File.ReadAllLines(strCustomerFilePath);
            int i = 0;
            while (i < arrayCustomerInformations.Length)
            {
                string strCustomerInfo = arrayCustomerInformations[i];
                string[] customerField = strCustomerInfo.Split(';');
                string strUsername = customerField[1];
                //we can not send money to ourselves
                if (!strUsername.Equals(strCustomer)) {
                    sendToComboBox.Items.Add(strUsername);
                }
                i++;
            }
        }

        //check if all fields are correctly entered : True if there's one
        public Boolean checkFields()
        {
            Boolean blnIsError = false;
            double dblBalance = ((HomePageForm)this.Owner).getBalance();
            if (amountTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Fill all fields !");
                blnIsError = true;
                return blnIsError;
            }
            else if (this.sendToComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select the recipient ! ");
                blnIsError = true;
                return blnIsError;
            }

            else if (passwordTextBox.Text != ((HomePageForm)this.Owner).getPassword()) {
                MessageBox.Show("Wrong Password ! ");
                blnIsError = true;
                return blnIsError;
            }
            else if (!robotCheckBox.Checked) {
                blnIsError = true;
                MessageBox.Show(" Are you a robot ?");
                return blnIsError;
            }
            double dblAmount;
            if (Double.TryParse(amountTextBox.Text, out dblAmount))
            {
                if (dblAmount <= 0)
                {
                    MessageBox.Show("the amount must be positive !");
                    blnIsError = true;
                    return blnIsError;
                }
                else if (dblAmount > dblBalance)
                {
                    MessageBox.Show("Sorry ! You do not have enough money !");
                    blnIsError = true;
                    return blnIsError;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number/n separator : US(.), FR(,)");
                blnIsError = true;
                return blnIsError;

            }

            return blnIsError;
        }

        //by clicking on Send Money Button
        private void SendMoneyBtn_Click(object sender, EventArgs e)
        {
            if (!checkFields())
            {
                succesPictureBox.Visible = true;
                List<string> credit = new List<string>();
                List<string> debit = new List<string>();
                strReceiver = this.sendToComboBox.SelectedItem.ToString();
                string strTransactionFilePath = ((HomePageForm)this.Owner).getTransactionFilePath();

                //multiply by -1 because it is a debit of funds
                dblAmount = Convert.ToDouble(amountTextBox.Text);
                double dblNegativeAmount = dblAmount * (-1);
                //add to list : Debit from the customer's account and credit into the receiving account
                //credit
                credit.Add(strReceiver);
                credit.Add(dblAmount.ToString());
                credit.Add(strCustomer);
                string strTransactionFieldsCredit = String.Join(";", credit).ToString();

                //debit
                debit.Add(strCustomer);
                debit.Add(dblNegativeAmount.ToString());
                debit.Add(strReceiver);
                string strTransactionFieldsDebit = String.Join(";", debit).ToString();

                //writing both transactions
                using (StreamWriter writetext = new StreamWriter(strTransactionFilePath, true))
                {
                    writetext.WriteLine(strTransactionFieldsDebit);
                    writetext.WriteLine(strTransactionFieldsCredit);
                }
                //decrease and increase balances
                ((HomePageForm)this.Owner).DebitAndtCreditAccount(strCustomer,strReceiver,dblAmount);
                //refresh HomePage
                ((HomePageForm)this.Owner).refreshBalanceAndTransaction(dblAmount);
                MessageBox.Show("You have Sent $"+dblAmount+" to "+strReceiver);
                this.Close();
            }

        }

        //exit
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
