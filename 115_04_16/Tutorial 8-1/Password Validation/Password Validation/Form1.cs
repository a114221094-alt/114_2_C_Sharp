using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // NumberUpperCase 方法接受一個字串參數
        // 並回傳該字串中包含的大寫字母數量。
        private int NumberUpperCase(string str)
        {
            int count = 0;// 用來計數大寫字母的變數
            foreach (char c in str)// 遍歷字串中的每個字元
            {
                if (char.IsUpper(c))// 如果字元 c 是大寫字母
                {
                    count++;// 大寫字母數量加1
                }
            }
            return count;
        }

        // NumberLowerCase 方法接受一個字串參數
        // 並回傳該字串中包含的小寫字母數量。
        private int NumberLowerCase(string str)
        {
            int count = 0;// 用來計數小寫字母的變數
            foreach (var item in str)// 遍歷字串中的每個字元
            {
                if (char.IsLower(item))// 如果字元 item 是小寫字母
                {
                    count++;// 小寫字母數量加1
                }
            }
            return count;
        }

        // NumberDigits 方法接受一個字串參數
        // 並回傳該字串中包含的數字字元數量。
        private int NumberDigits(string str)
        {
            int count = 0;// 用來計數數字字元的變數
            foreach (var item in str)// 遍歷字串中的每個字元
            {
                if (char.IsDigit(item))// 如果字元 item 是數字字元
                {
                    count++;// 數字字元數量加1
                }
            }
            return count;
        }

        private void checkPasswordButton_Click(object sender, EventArgs e)
        {
            const int MIN_LENGTH = 8;// 密碼的最小長度
            string password = passwordTextBox.Text;// 從 TextBox 控制項中取得使用者輸入的密碼
            if (password.Length < MIN_LENGTH)
            {
                MessageBox.Show("密碼長度至少為8個字元。");
                return;
            }
            else
            {
                int upperCaseCount = NumberUpperCase(password);
                int lowerCaseCount = NumberLowerCase(password);
                int digitCount = NumberDigits(password);
                if (upperCaseCount < 1)
                {
                    MessageBox.Show("密碼必須包含至少一個大寫字母。");
                    return;
                }
                else if (lowerCaseCount < 1)
                {
                    MessageBox.Show("密碼必須包含至少一個小寫字母。");
                    return;
                }
                else if (digitCount < 1)
                {
                    MessageBox.Show("密碼必須包含至少一個數字。");
                    return;
                }
                else
                {
                    MessageBox.Show("密碼符合規則！");
                }

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
