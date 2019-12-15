using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankOnline
{
    public partial class BankOnlineForm : Form
    {
        //Forms
        HomePageForm HomePageForm;
        AccountCreationForm AccountCreationForm;
        AboutForm AboutForm;

        //Fields : files location
        private string strCustomerFilePath;          //location of customer.txt file
        private string strTransactionFilePath;       //location of transaction.txt file
        private string[] arrayCustomerInformations;

        //customer's fields
        private string strName;         //Name
        private string strUsername;     //username
        private string strGender;       //Gender
        private double dblBalance;      //Balance
        private string strPassword;     //password

        public BankOnlineForm()
        {
            InitializeComponent();
            AboutForm = new AboutForm(); 
            strCustomerFilePath = "../../../BankData/customers.txt";
            strTransactionFilePath = "../../../BankData/transactions.txt";
            strName = "";
            strUsername = "";
            strGender = "";
            dblBalance = 0.0;
            strPassword = "";
            this.createFileAndAdminUser();
            this.ActiveControl = userNameTextBox;
        }
        
        public void createFileAndAdminUser()
        {
            //create files if not exist
            if (!File.Exists(strCustomerFilePath))
            {
                using (StreamWriter sw = File.AppendText(strCustomerFilePath))
                {
                    //Default users
                    string strAdmin = "Administrator;admin;Unknown;admin;100000";
                    string strAria = "Aria Stark;aria;Female;aria;5000";
                    sw.WriteLine(strAdmin);
                    sw.WriteLine(strAria);
                    //File.CreateText(strTransactionFilePath);
                    using (StreamWriter sw2 = File.AppendText(strTransactionFilePath)) {
                        string strTransaction1 = "admin; -1000; aria";
                        string strTransaction2 = "aria; 1000; admin";
                        sw2.WriteLine(strTransaction1);
                        sw2.WriteLine(strTransaction2);
                    }
                }
            }
        }

        //accessors----------------------------
        public string getCustomerFilePath()
        {
            return this.strCustomerFilePath;
        }

        public string getTransactionFilePath()
        {
            return strTransactionFilePath;
        }

        //clear all textBoxes
        public void clearFields()
        {
            this.userNameTextBox.Text = string.Empty;
            this.passwordTextBox.Text = string.Empty;
            strUsername = string.Empty;
            strPassword = string.Empty;
            this.errorLoginPictureBox1.Visible = false;
            this.errorLoginPictureBox2.Visible = false;
        }

        //by clicking on Create an Account button
        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            AccountCreationForm = new AccountCreationForm();
            AccountCreationForm.Owner = this;
            AccountCreationForm.ShowDialog();
        }

        //Checks if all fiels are correct
        public Boolean checkCustomerInformation()
        {
            //read customer.txt file
            this.arrayCustomerInformations = File.ReadAllLines(strCustomerFilePath);

            if (arrayCustomerInformations.Length == 0)
            {
                this.errorLoginPictureBox1.Visible = true;
                this.errorLoginPictureBox2.Visible = true;
                MessageBox.Show("Invalid Account ID or password");
                return false;
            }
            else
            {
                int i = 0;
                while ( i<arrayCustomerInformations.Length)
                {
                    string strCustomer = arrayCustomerInformations[i];
                    string[] customerField = strCustomer.Split(';');
                    strName = customerField[0];
                    strUsername = customerField[1];
                    strGender = customerField[2];
                    if (!Double.TryParse(customerField[4], out dblBalance))
                    {
                        this.errorLoginPictureBox1.Visible = true;
                        MessageBox.Show("Mauvais format des Balance (./,)");
                        this.errorLoginPictureBox1.Visible = false;
                    }

                    strPassword = customerField[3];
                    if(strPassword==passwordTextBox.Text && strUsername ==userNameTextBox.Text)
                    {
                        return true;
                    }
                    i++;
                }
                return false;
            }
        }

        //by clicking on Log In button
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //verify that all fields entered are correct
            //if they are all correct
            if (this.checkCustomerInformation())
            {
                HomePageForm = new HomePageForm(strName, strUsername, strGender, dblBalance, strPassword);
                HomePageForm.Owner = this;
                HomePageForm.ShowDialog();
                clearFields();
                this.ActiveControl = this.userNameTextBox;
            }
            //in case of empty fields
            else if(userNameTextBox.Text=="" || passwordTextBox.Text == "")
            {
                this.errorLoginPictureBox1.Visible = true;
                this.errorLoginPictureBox2.Visible = true;
                MessageBox.Show("Please fill all fields !");
                this.errorLoginPictureBox1.Visible = false;
                this.errorLoginPictureBox2.Visible = false;
                this.ActiveControl= this.userNameTextBox;
            }
            else
            {
                this.errorLoginPictureBox1.Visible = true;
                this.errorLoginPictureBox2.Visible = true;
                MessageBox.Show("Invalid Account Username or password");
                this.errorLoginPictureBox1.Visible = false;
                this.errorLoginPictureBox2.Visible = false;
                this.ActiveControl = this.userNameTextBox;
                
            }

            strName = "";
            strUsername = "";
        }

        //exit
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //--------------- Menu Strip
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createAnAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.createAccountBtn_Click(sender, e);
        }

        private void clearAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.clearFields();
        }

        //--------------- Context Menu
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutForm.Owner = this;
            AboutForm.ShowDialog();
        }

        private void createAnAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.createAccountBtn_Click(sender, e);
        }

        private void clearAllToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.clearFields();
        }

    }
}
