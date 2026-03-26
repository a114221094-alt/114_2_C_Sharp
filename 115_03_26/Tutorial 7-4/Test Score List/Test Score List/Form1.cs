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

namespace Test_Score_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadScores(List<int> scoresList)
        {
            string filePath = "TestScores.txt"; // 分數檔案的路徑
            // 從檔案中讀取分數並存入 List 集合
            try
            {
                using (StreamReader reader = File.OpenText(filePath))
                {
                    string line;
                    while (!reader.EndOfStream)
                    {
                        scoresList.Add(int.Parse(reader.ReadLine()));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading scores: " + ex.Message);
            }
        }

        // DisplayScores 方法用來在列表框中顯示所有分數
        private void DisplayScores(List<int> scoresList)
        {
            int index = 1; // 用來顯示分數的序號
            foreach (int score in scoresList)
            {
                testScoresListBox.Items.Add((index++) + "; " + score);
            }
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            double averageScore;    // 用來儲存平均分數
            int numAboveAverage;    // 用來儲存高於平均分數的數量
            int numBelowAverage;    // 用來儲存低於平均分數的數量

            // 建立一個 List 集合來儲存分數
            List<int> scoresList = new List<int>();

            // 從檔案中讀取分數並存入 List 集合
            ReadScores(scoresList);

            // 在列表框中顯示所有分數
            DisplayScores(scoresList);

            // 計算並顯示平均分數
            averageScore = Average(scoresList);
            averageLabel.Text = averageScore.ToString("n1");

            // 計算並顯示高於平均分數的數量
            numAboveAverage = AboveAverage(scoresList, averageScore);
            aboveAverageLabel.Text = numAboveAverage.ToString();

            // 計算並顯示低於平均分數的數量
            numBelowAverage = BelowAverage(scoresList);
            belowAverageLabel.Text = numBelowAverage.ToString();
        }

        //searchButton_Click 方法用來搜尋分數並顯示結果
        private void searchButton_Click(object sender, EventArgs e)
        {
            int searchScore;   // 用來儲存使用者輸入的分數
            int position;         // 用來儲存搜尋到的分數的索引
            // 取得使用者輸入的分數
            if (!int.TryParse(searchTextBox.Text, out searchScore))
            {
                searchResultLabel.Text = "Please enter a valid score.";
            }

            if ((position = testScoresListBox.IndexOf(searchScore)) != -1)
            {
                searchResultLabel.Text = "Score found at position: " + (position + 1);
                return;
            }

            else
            {
               searchResultLabel.Text = "Score not found.";
                return;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
