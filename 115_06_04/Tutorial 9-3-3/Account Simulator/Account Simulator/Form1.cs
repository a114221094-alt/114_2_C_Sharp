using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Simulator
{
    public partial class Form1 : Form
    {
        private BankAccount account = new BankAccount(20000m); 
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            balanceDescriptionLabel.Text = account.Balance.ToString("C");

        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(depositTextBox.Text, out amount))
            {
                account.Deposit(amount);
                balanceDescriptionLabel.Text = account.Balance.ToString("C");
                depositTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Invalid deposit amount.");
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
           
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        // 新增 balanceLabel_Click 事件處理方法以修正 CS1061
        private void balanceLabel_Click(object sender, EventArgs e)
        {
            // 可選：此處可根據需求加入顯示訊息或其他功能
            // 目前不執行任何操作
        }
    }
}
