using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Unformat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // IsValidFormat 方法接受一個字串引數，
        // 並判斷它是否正確格式化為以下的
        // 電話號碼格式：
        // (XX) XXXX-XXXX
        // 如果引數格式正確，該方法傳回 true，否則傳回 false。
        private bool IsValidFormat(string str)
        {
           if(str.Length != 14)
                return false;
            if (str[0] != '(' || str[3] != ')' || str[4] != ' ' || str[9] != '-')
                return false;
            for (int i = 1; i <= 2; i++)
            {
                if (!char.IsDigit(str[i]))
                    return false;
            }
            for (int i = 5; i <= 8; i++)
            {
                if (!char.IsDigit(str[i]))
                    return false;
            }
            for (int i = 10; i <= 13; i++)
            {
                if (!char.IsDigit(str[i]))
                    return false;
            }
            return true;
        }

        // Unformat 方法藉由參考（by reference）接受一個字串，
        // 假設該字串包含以下格式的電話號碼：(XX) XXXX-XXXX。
        // 此方法透過移除括號、空格與連字號來解除字串的格式。
        private void Unformat(ref string str)
        {
            str=str.Substring(1, 2) + str.Substring(5, 4) + str.Substring(10, 4);
        }

        private void unformatButton_Click(object sender, EventArgs e)
        {
            string input = numberTextBox.Text;
            if (IsValidFormat(input))
            {
                Unformat(ref input);
                MessageBox.Show("解除格式後的號碼: " + input);
            }
            else
            {
                MessageBox.Show("格式無效。請輸入格式為 (XX) XXXX-XXXX 的電話號碼。");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }

        private void instructionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
