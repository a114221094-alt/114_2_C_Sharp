using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiform_Practice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void displayFormButton_Click(object sender, EventArgs e)
        {
            // 建立 MessageForm 類別的執行個體。
            // 由於尚未建立 MessageForm，這裡先保持原樣，僅更新註解。
            MessageForm mymessageForm = new MessageForm(); // 這行會產生錯誤，因為 MessageForm 尚未定義。
            // 顯示該表單。
            mymessageForm.Show(); // 這行也會產生錯誤，因為 MessageForm 尚未定義。

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單，結束應用程式。
            this.Close();
        }
    }
}
