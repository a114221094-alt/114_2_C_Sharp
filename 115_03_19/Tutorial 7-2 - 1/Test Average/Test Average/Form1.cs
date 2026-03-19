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

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Average 方法接收一個 int 陣列作為引數
        // 並回傳該陣列中所有數值的平均值。
        private double Average(int[] sArray, int count)
        {
           int total = 0;
            for (int i = 0; i < count; i++)
            {
                total += sArray[i];
            }
            return (double)total / sArray.Length;
        }

        // Highest 方法接收一個 int 陣列作為引數
        // 並回傳該陣列中的最高數值。
        private int Highest(int[] sArray, int count)
        {
           int highest = sArray[0];
            for (int i = 1; i < count; i++)
            {
                if (sArray[i] > highest)
                {
                    highest = sArray[i];
                }
            }
            return highest;
        }

        // Lowest 方法接收一個 int 陣列作為引數
        // 並回傳該陣列中的最低數值。
        private int Lowest(int[] sArray, int count)
        {
           int lowest = sArray[0];
            for (int i = 1; i < count; i++)
            {
                if (sArray[i] < lowest)
                {
                    lowest = sArray[i];
                }
            }
            return lowest;
        }

        // 當使用者點擊「取得成績」按鈕時會觸發此事件處理常式
        private void getScoresButton_Click(object sender, EventArgs e)
        {
            const int SIZE = 60;
            int[] scores = new int[SIZE];
            StreamReader inputFile;
            int index = 0;

            try
            {
                inputFile = File.OpenText("TestScores.txt");
                while (!inputFile.EndOfStream && index < scores.Length)
                {
                    scores[index] = int.Parse(inputFile.ReadLine());
                    index++;
                }
                inputFile.Close();

                foreach (int val in scores)
                {
                    testScoresListBox.Items.Add(val);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
            
            averageScoreLabel.Text = Average(scores, index).ToString("n2");
            highScoreLabel.Text = Highest(scores, index).ToString();
            lowScoreLabel.Text = Lowest(scores, index).ToString();
        }

        // 當使用者點擊「離開」按鈕時會觸發此事件處理常式
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前表單，結束應用程式。
            this.Close();
        }
    }
}
