using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cell_Phone_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The GetPhoneData method accepts a CellPhone object
        // as an argument. It assigns the data entered by the
        // user to the object's properties.
        private void GetPhoneData(CellPhone phone)
        {
            phone.Brand = brandTextBox.Text;
            phone.Model = modelTextBox.Text;
            if (decimal.TryParse(priceTextBox.Text, out decimal price))
            {
                phone.Price = price.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid price.");
                phone.Price = "0";
            }
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            CellPhone myPhone = new CellPhone();

            GetPhoneData(myPhone);

            brandLabel.Text = myPhone.Brand;
            modelLabel.Text = myPhone.Model;

            // 修正：將 string 轉為 decimal 再格式化為貨幣字串
            if (decimal.TryParse(myPhone.Price, out decimal price))
            {
                priceLabel.Text = price.ToString("C");
            }
            else
            {
                priceLabel.Text = 0m.ToString("C");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
