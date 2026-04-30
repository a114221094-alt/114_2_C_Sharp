using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Phonebook
{
    struct PhoneBookEntry
    {
        public string name;
        public string phone;
    }

    public partial class Form1 : Form
    {
        // 用於儲存 PhoneBookEntry 物件清單的欄位。
        private List<PhoneBookEntry> phoneList = new List<PhoneBookEntry>();


        public Form1()
        {
            InitializeComponent();
        }

        // ReadFile 方法讀取 PhoneList.txt 檔案的內容，
        // 並將資料做為 PhoneBookEntry 物件儲存至 phoneList 中。
        private void ReadFile()
        {
            try
            {
                StreamReader inputFile;
                string line;
                char[] delim = { ',' };
                PhoneBookEntry entry = new PhoneBookEntry();

                using (inputFile = File.OpenText("PhoneList.txt"))
                {
                    while (!inputFile.EndOfStream)
                    {
                        line = inputFile.ReadLine();
                        string[] tokens = line.Split(delim);
                        if (tokens.Length == 2)
                        {
                            entry.name = tokens[0].Trim();
                            entry.phone = tokens[1].Trim();
                            phoneList.Add(entry);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀取檔案時發生錯誤: " + ex.Message);
            }
        }

        // DisplayNames 方法將姓名清單顯示
        // 於 nameListBox 控制項中。
        private void DisplayNames()
        {
            foreach (PhoneBookEntry entry in phoneList)
            {
                nameListBox.Items.Add(entry.name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 讀取 PhoneList.txt 檔案。
            ReadFile();

            // 顯示姓名。
            DisplayNames();
        }

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = nameListBox.SelectedIndex;
            if (index != -1) 
            {
                string phone = phoneList[index].phone;
                phoneLabel.Text = phoneList[index].phone;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
