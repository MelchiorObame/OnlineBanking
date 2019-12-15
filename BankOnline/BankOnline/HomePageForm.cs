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
    public partial class HomePageForm : Form
    {
        SendMoneyForm SendMoneyForm;
        //const array of Currency          [yen, euro, us dollar, yuan, Ruble, swiss franc, BitCoin]
        readonly double[] CURRENCY = new double[] { 108.62, 0.9, 1, 7.07, 64.13, 0.99, 0.00014 };

        //customer fields
        private string strName;
        private string strUsername;
        private string strGender;
        private double dblBalance;
        private string strPassword;

        private string[] arrayCustomerTransaction;
        private List<string> listTransaction;
        private string strTransactionFilePath;


        public HomePageForm(string name, string username, string gender, double balance, string password)
        {
            InitializeComponent();
            strName = name;
            strUsername = username;
            strGender = gender;
            dblBalance = balance;
            strPassword = password;
            listTransaction = new List<string>();
            strTransactionFilePath = "../../../BankData/transactions.txt";
            this.UpdateFields();
        }

        //get Password
        public string getPassword()
        {
            return strPassword;
        }

        //get actual Balance
        public double getBalance()
        {
            return dblBalance;
        }

        public string getTransactionFilePath() {
            return strTransactionFilePath;
        }

        //udpade labels and listBoxes
        public void UpdateFields()
        {
            this.userNameLabel.Text = strUsername;
            this.nameLabel.Text = strName;
            this.genderLabel.Text = strGender;
            this.balanceLabel.Text = dblBalance.ToString();
            //disabled sending button if balance is null.
            if (dblBalance <= 0) {
                sendMoneyBtn.Enabled = false;
            }

            this.arrayCustomerTransaction = File.ReadAllLines(strTransactionFilePath);
            if (this.arrayCustomerTransaction != null)
            {
                for (int i = 0; i < arrayCustomerTransaction.Length; i++)
                {
                    string transaction = arrayCustomerTransaction[i];
                    string[] transactionFields = transaction.Split(';');
                    string strCustomerUsername = transactionFields[0];
                    double dblCustomerAmount = Convert.ToDouble(transactionFields[1]);
                    string strReceiver = transactionFields[2];
                    if (strCustomerUsername == strUsername)
                    {
                        if (dblCustomerAmount >= 0)
                        {
                            transactionListBox.Items.Add("< Received from " + strReceiver + " : +" + dblCustomerAmount.ToString() + " $");
                        }
                        else
                        {
                            transactionListBox.Items.Add("> Sent to " + strReceiver + " : " + dblCustomerAmount.ToString() + " $");
                        }

                    }
                }

            }
            
            // show the user's image if it exists :  png or jpg
            string strImagePath = "../../../pics/users/" + this.strUsername;
            if (File.Exists(strImagePath+".png"))
            {
                this.pictureBox.Image = Image.FromFile(strImagePath + ".png");
            }
            else if (File.Exists(strImagePath+".jpg"))
            {
                this.pictureBox.Image = Image.FromFile(strImagePath + ".jpg");
            }
        }

        //refresh just balance and listBox's transaction after sending money. (rewrite transactions in ListBox)
        public void refreshBalanceAndTransaction(double amount)
        {
            //update transaction
            dblBalance -= amount;
            transactionListBox.Items.Clear();
            this.UpdateFields();
        }

        //increases and decreases the account balances credited and debited respectively
        public void DebitAndtCreditAccount(string customer, string receiver, double amount){
            string[] arrayCustomerInformations = File.ReadAllLines(((BankOnlineForm)this.Owner).getCustomerFilePath());
            int i = 0;
            while (i < arrayCustomerInformations.Length)
            {
                string strCustomerInfo = arrayCustomerInformations[i];
                string[] customerField = strCustomerInfo.Split(';');
                string strUsername = customerField[1];
                double dblCustomerBalance = 0;
                //debit sender account
                if (strUsername.Equals(customer))
                {
                    if (double.TryParse(customerField[4], out dblCustomerBalance))
                    {
                        //modify line in arrayCustomerInformations
                        customerField[4] = (dblCustomerBalance - amount).ToString();
                        arrayCustomerInformations[i] = string.Join(";",customerField );
                        
                    }
                    else
                    {
                        Console.WriteLine("Impossible de recuperer les balance en double");
                    }
                }
                //credit receiver account
                else if (strUsername.Equals(receiver))
                {
                    if (double.TryParse(customerField[4], out dblCustomerBalance))
                    {
                        //modify line in arrayCustomerInformations
                        customerField[4] = (dblCustomerBalance + amount).ToString();
                        arrayCustomerInformations[i] = string.Join(";", customerField);
                    }
                    else
                    {
                        Console.WriteLine("Impossible de recuperer les balance en double");
                    }
                }
                i++;
            }
            //creation du nouveau fichier
            //clear all data
            File.WriteAllText(((BankOnlineForm)this.Owner).getCustomerFilePath(), String.Empty);
            //create new dataFile
            for (int j = 0; j < arrayCustomerInformations.Length; j++) {
                using (StreamWriter writetext = new StreamWriter(((BankOnlineForm)this.Owner).getCustomerFilePath(), true))
                {
                    writetext.WriteLine(arrayCustomerInformations[j]);
                }
            }
        }

        //by clicking on the conversion button
        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            //get currency
            int intIndex = 0;
            if (this.currencyComboBox.SelectedItem != null)
            {
                intIndex = this.currencyComboBox.SelectedIndex;
            }
            resultConvLabel.Text = (this.CURRENCY[intIndex] * dblBalance).ToString();
        }

        //Log Out
        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //by clicking on the Send Money button
        private void SendMoneyBtn_Click(object sender, EventArgs e)
        {
            SendMoneyForm = new SendMoneyForm(this.strUsername);
            SendMoneyForm.Owner = this;
            SendMoneyForm.ShowDialog();
        }

        //---------------  context menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sendMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SendMoneyBtn_Click(sender, e);
        }
    }
}
