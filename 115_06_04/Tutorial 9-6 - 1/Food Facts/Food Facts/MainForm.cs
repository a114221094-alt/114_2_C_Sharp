using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Facts
{
    public partial class MainForm : Form
    {
        public FoodItem selectedFood;
        public MainForm()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            
            

            // 根據選取的選項按鈕設定營養資訊。
            if (bananaRadioButton.Checked)
            {
                selectedFood = new FoodItem("1 根香蕉", 100, 0.4, 27);
            }
            else if (popcornRadioButton.Checked)
            {
                selectedFood = new FoodItem("1 杯氣炸爆米花", 31, 0.4, 6);
            }
            else if (muffinRadioButton.Checked)
            {
                selectedFood = new FoodItem("1 個大藍莓瑪芬", 385, 9, 67);
            }

            // 建立 NutritionForm 類別的實例。
            NutritionForm nutriForm = new NutritionForm(selectedFood);

            // 顯示 NutritionForm。
            nutriForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
