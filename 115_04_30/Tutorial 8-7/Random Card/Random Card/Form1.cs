using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCardButton_Click(object sender, EventArgs e)
        {
            // 建立一個 Random 物件。
            Random rand = new Random();

            // 取得一個隨機索引。
            int index = rand.Next(cardImageList.Images.Count);

            // 顯示一張卡片。
            cardPictureBox.Image = cardImageList.Images[index];
        }

        private void cardPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
