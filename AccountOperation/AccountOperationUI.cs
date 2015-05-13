using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperation
{
    public partial class AccountOperationUI : Form
    {
        public AccountOperationUI()
        {
            InitializeComponent();
        }
        Account myAccount=new Account();

        private void createAccButton_Click(object sender, EventArgs e)
        {
            myAccount.accountNumber = accountNumberTextBox.Text;
            myAccount.customerName = customerNameTextBox.Text;
            MessageBox.Show("Account is created");
            accountNumberTextBox.Clear();
            customerNameTextBox.Clear();

        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            myAccount.depositAmount = Convert.ToDouble(amountTextBox.Text);
            myAccount.DepositMoney();
            MessageBox.Show(myAccount.depositAmount + "Taka is depositd");
            amountTextBox.Clear();
        }

        private void withDrawButton_Click(object sender, EventArgs e)
        {
            myAccount.withDrawAmount = Convert.ToDouble(amountTextBox.Text);
            if()
            myAccount.WitdrawMoney();
            MessageBox.Show(myAccount.withDrawAmount + "Taka is withdrwed");
            amountTextBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myAccount.customerName + ", Your account number " +
                            myAccount.accountNumber + " and balance is " + myAccount.totalMoney);
        }
    }
}
