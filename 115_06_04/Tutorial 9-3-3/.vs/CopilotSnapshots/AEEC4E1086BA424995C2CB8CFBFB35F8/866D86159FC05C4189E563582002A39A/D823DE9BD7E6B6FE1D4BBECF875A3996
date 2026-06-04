using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_9_3_3
{
    // 銀行帳戶類別，負責處理帳戶的餘額、存款與提款功能
    public class BankAccount
    {
        // 儲存帳戶目前的餘額
        private decimal balance;

        public string AccountNumber { get; set; }
        public string Name { get; set; }

        // 建構子，在建立物件時初始化帳戶與餘額
        public BankAccount(string accountNumber, string name, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Name = name;
            balance = initialBalance;
        }

        // 取得目前帳戶餘額的屬性，唯讀
        public decimal Balance
        {
            get { return balance; }
        }

        // 存款方法，傳入要存入的金額
        public void Deposit(decimal amount)
        {
            // 確保存入金額大於 0
            if (amount > 0)
            {
                balance += amount;
            }
        }

        // 提款方法，傳入要提領的金額
        public void Withdraw(decimal amount)
        {
            // 確保提請金額大於 0 且且小於等於目前餘額
            if (amount > 0 && amount <= balance)
            {
                // 扣除餘額
                balance -= amount;
            }
            else
            {
                // 餘額不足或無效的金額提示
                MessageBox.Show("餘額不足或無效的金額。");
            }
        }
    }
}

