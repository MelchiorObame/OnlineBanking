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
    public partial class AccountCreationForm : Form
    {
        //Fields
        private string strName;
        private string strUsername;
        private string strPassword;
        private string strGender;
        private double dblBalance;

        public AccountCreationForm()
        {
            InitializeComponent();
            strName = "";
            strUsername = "";
            strPassword = "";
            strGender = "";
            dblBalance = 0.0;
        }

        //exit
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //check all textBoxes : true if there's no error
        public Boolean errorCheckFields() {          
            Boolean isError = false;
            if (nameTextBox.Text == "" || userNameTextBox.Text == "" || passwordConfirmationTextBox.Text=="" || passwordTextBox.Text=="") {
                isError = true;
                MessageBox.Show("fill empty fields !");
            }
            else if(passwordConfirmationTextBox.Text!= passwordTextBox.Text)
            {
                isError = true;
                MessageBox.Show("Please enter the same password !");
            }
            else if (!conditionCheckBox.Checked)
            {
                isError = true;
                MessageBox.Show(" You have to accept conditions!");
            }
            
            //check if username already exists
            else if(nameTextBox.Text != "")
            {
                string[] arrayCustomerInformations = File.ReadAllLines(((BankOnlineForm)this.Owner).getCustomerFilePath());
                int i = 0;
                while (i < arrayCustomerInformations.Length)
                {
                    string strCustmer = arrayCustomerInformations[i];
                    string[] customerField = strCustmer.Split(';');
                    strName = customerField[0];
                    strUsername = customerField[1];
                    if (userNameTextBox.Text==strUsername)
                    {
                        isError = true;
                        MessageBox.Show("User already exists! Please change your Username");
                    }
                    i++;
                }
            }
            return isError;
        }

        //by clicking on create an account button 
        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            string strCustomerFile = ((BankOnlineForm)this.Owner).getCustomerFilePath();
            List<string> customer = new List<string>();                     //customer fields

            //if all fields are correct
            if (!errorCheckFields()) {

                strName = nameTextBox.Text;
                strUsername = userNameTextBox.Text;
                // select the text  of the checked radio button
                var checkedRadioButton = this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                if (checkedRadioButton != null)
                {
                    strGender = checkedRadioButton.Text;
                }
                strPassword = passwordTextBox.Text;
                
                customer.Add(strName);
                customer.Add(strUsername);
                customer.Add(strGender);
                customer.Add(strPassword);
                customer.Add(dblBalance.ToString());

                //concats fields and writes line in customer.txt file
                string strCustomerFields = String.Join(";", customer).ToString();
                using (StreamWriter writetext = new StreamWriter(strCustomerFile, true))
                {

                    writetext.WriteLine(strCustomerFields);
                }
                MessageBox.Show(strUsername+", Your Account is created !");
                this.Close();
            }
            
        }


    }
}
