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

namespace CSV_Reader
{
    struct Student
    {
        public string Class;
        public string ID;
        public string Name;
        public int[] Scores;
    }
    public partial class Form1 : Form
    {
        private List<Student> gradeBook  = new List<Student>();
        public Form1()
        {
            // 初始化表單的所有UI元件
            InitializeComponent();
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                gradeBook.Clear();
                averagesListBox.Items.Clear();
                
                using (StreamReader inputFile = File.OpenText("Gradeses.csv"))
                {
                    string line;
                    while ((line = inputFile.ReadLine()) != null)
                    {
                        string[] fields = line.Split(',');
                        
                        if (fields.Length > 0)
                        {
                            // 將 CSV 讀取到的資料存入 Student 結構
                            Student student = new Student();
                            student.Name = fields[0]; // 假設第一個欄位為姓名
                            
                            // 讀取所有分數
                            student.Scores = new int[fields.Length - 1];
                            for (int i = 1; i < fields.Length; i++)
                            {
                                int.TryParse(fields[i], out student.Scores[i - 1]);
                            }

                            // 將學生資料加入 List 中
                            gradeBook.Add(student);
                        }
                    }
                }

                // 透過 gradeBook 資料結構讀取並顯示結果
                foreach (Student s in gradeBook)
                {
                    double average = 0;
                    if (s.Scores != null && s.Scores.Length > 0)
                    {
                        average = s.Scores.Average(); // 使用 LINQ 計算平均
                    }
                    averagesListBox.Items.Add($"{s.Name} 的平均分數是 {average:F2}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單
            this.Close();
        }
    }
}
