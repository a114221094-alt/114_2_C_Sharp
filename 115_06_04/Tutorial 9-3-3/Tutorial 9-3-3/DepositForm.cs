using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_9_3_3
{
    public partial class DepositForm : Form
    {
        private List<BankAccount> accounts;

        public DepositForm(List<BankAccount> accounts)
        {
            InitializeComponent();
            this.accounts = accounts;
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            string accountNumber = textBoxAccountNo.Text;
            if (decimal.TryParse(textBoxAmount.Text, out decimal amount))
            {
                var account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
                if (account != null)
                {
                    account.Deposit(amount);
                    MessageBox.Show($"存款成功！目前餘額為：{account.Balance}");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("找不到該帳號！");
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的金額！");
            }
        }
    }
}
