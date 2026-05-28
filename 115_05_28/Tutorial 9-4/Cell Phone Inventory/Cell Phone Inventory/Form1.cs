using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cell_Phone_Inventory
{
    public partial class Form1 : Form
    {
        // 存放CellPhone物件的清單
        List<CellPhone> phoneList = new List<CellPhone>();

        public Form1()
        {
            InitializeComponent();
        }

        // GetPhoneData方法接收一個CellPhone物件
        // 作為參數。它會將使用者輸入的資料
        // 指派給物件的屬性。
        private void GetPhoneData(CellPhone phone)
        {
            // 用來存放價格的暫存變數。
            decimal price;

            // 取得手機的品牌。
            phone.Brand = brandTextBox.Text;

            // 取得手機的型號。
            phone.Model = modelTextBox.Text;

            // 取得手機的價格。
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                // 顯示錯誤訊息。
                MessageBox.Show("無效的價格");
            }
        }

        private void addPhoneButton_Click(object sender, EventArgs e)
        {
            CellPhone myPhone = new CellPhone();
            GetPhoneData(myPhone);
            phoneList.Add(myPhone);
            phoneListBox.Items.Add(myPhone.Brand + " " + myPhone.Model + " - $" + myPhone.Price);

            brandTextBox.Clear();
            modelTextBox.Clear();
            priceTextBox.Clear();

            brandTextBox.Focus();

        }

        private void phoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = phoneListBox.SelectedIndex;
            if (index != -1)
            {
                CellPhone selectedPhone = phoneList[index];
                MessageBox.Show("\n價格: $" + selectedPhone.Price);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
