using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Multiform_Practice
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 啟用應用程式的視覺樣式
            Application.EnableVisualStyles();
            // 設定相容文字轉譯預設值為 false
            Application.SetCompatibleTextRenderingDefault(false);
            // 執行主要表單 MainForm
            Application.Run(new MainForm());
        }
    }
}
