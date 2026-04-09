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
        private double Average(int[] sArray)
        {
           int total = 0;
            for (int i = 0; i < sArray.Length; i++)
            {
                total += sArray[i];
            }
            return (double)total / sArray.Length;
        }

        // Highest 方法接收一個 int 陣列作為引數
        // 並回傳該陣列中的最高數值。
        private int Highest(int[] sArray)
        {
            int[] scoreCopy = new int[sArray.Length];
            for(int i = 0; i < sArray.Length; i++)
            {
                scoreCopy[i] = sArray[i];
            }
            Array.Sort(scoreCopy);
            return scoreCopy[scoreCopy.Length-1];
        }

        // Lowest 方法接收一個 int 陣列作為引數
        // 並回傳該陣列中的最低數值。
        private int Lowest(int[] sArray)
        {
            int[] scoreCopy = new int[sArray.Length];
            for (int i = 0; i < sArray.Length; i++)
            {
                scoreCopy[i] = sArray[i];
            }
            Array.Sort(scoreCopy);
            return scoreCopy[0];
        }

        private int getFileScoreCount()
        {
            int count = 0;
            StreamReader inputFile;
            try
            {
                inputFile = File.OpenText("TestScores.txt");
                while (!inputFile.EndOfStream )
                {
                    inputFile.ReadLine();
                    count++;
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return count;
        }
        // 當使用者點擊「取得成績」按鈕時會觸發此事件處理常式
        private void getScoresButton_Click(object sender, EventArgs e)
        {
            int count = getFileScoreCount();
            if (count == 0) return;

            int[] scores = new int[count];
            StreamReader inputFile;
            int index = 0;

            try
            {
                inputFile = File.OpenText("TestScores.txt");
                
                // 清空原本的項目避免重複加入
                testScoresListBox.Items.Clear();
                testScoresListBox.Items.Add("學生人數: " + count + "人");

                while (!inputFile.EndOfStream && index < scores.Length)
                {
                    string line = inputFile.ReadLine();
                    
                    // 以空白字元分割讀取到的字串
                    string[] parts = line.Split(' ');
                    
                    if (parts.Length >= 2)
                    {
                        string studentId = parts[0];
                        scores[index] = int.Parse(parts[1]);
                        
                        // 在 ListBox 上顯示 "學號 分數"
                        testScoresListBox.Items.Add(studentId + " " + scores[index]);
                        index++;
                    }
                }
                inputFile.Close();

                averageScoreLabel.Text = Average(scores).ToString("n2");
                highScoreLabel.Text = Highest(scores).ToString();
                lowScoreLabel.Text = Lowest(scores).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // 當使用者點擊「離開」按鈕時會觸發此事件處理常式
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前表單，結束應用程式。
            this.Close();
        }
    }
}
