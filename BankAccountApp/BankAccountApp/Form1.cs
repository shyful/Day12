using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Customer aCustomer;
        private Account anAccount;
        private void saveButton_Click(object sender, EventArgs e)
        {
            anAccount=new Account();
            anAccount.Number = accountNumberEntryTextBox.Text;
            anAccount.OpeningDate = openningDateEntryTextBox.Text;
           
             aCustomer=new Customer();
            aCustomer.Name = nameEntryTextBox.Text;
            aCustomer.Email = emailEntryTextBox.Text;

            aCustomer.CustomerAccount = anAccount;
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (aCustomer != null)
            {
                double amount = Convert.ToDouble(amountextBox.Text);
                aCustomer.CustomerAccount.Deposit(amount);
                MessageBox.Show("Deposited"); 
            }
            else
            {
                MessageBox.Show("Create an account first");
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (aCustomer != null)
            {
                double amount = Convert.ToDouble(amountextBox.Text);
                if (amount > aCustomer.CustomerAccount.Balance)
                {
                    throw new Exception();
                    MessageBox.Show("Check your balance first!");

                }
                aCustomer.CustomerAccount.Withdraw(amount);
                MessageBox.Show("Withdrawn");   
            }
            else
            {
                MessageBox.Show("Create an account first");  
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            nameShowTextBox.Text = aCustomer.Name;
            emailShowTextBox.Text = aCustomer.Email;
            numberShowTextBox.Text = aCustomer.CustomerAccount.Number;
            showBalanceTextBox.Text = aCustomer.CustomerAccount.Balance.ToString();
            openningDateShowTextBox.Text = aCustomer.CustomerAccount.OpeningDate;


        }
    }
}
