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
    public partial class NutritionForm : Form
    {
        private FoodItem foodItem; // 修正：宣告 foodItem 欄位

        public NutritionForm(FoodItem foodItem)
        {
            InitializeComponent();
            this.foodItem = foodItem;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }

        private void NutritionForm_Load(object sender, EventArgs e)
        {
            foodLabel.Text = foodItem.Name;
            caloriesLabel.Text = foodItem.Calories.ToString();
            carbLabel.Text = foodItem.Carbohydrates.ToString();
            fatLabel.Text = foodItem.Fat.ToString();
        }
    }
}
