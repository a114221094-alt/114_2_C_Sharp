using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Q3
{
    public partial class Form1 : Form
    {
        private int[] generatedNumbers = null; // length 5 when set
        private int[] drawNumbers = null; // length 5 when set
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            UpdateControlStates();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            generatedNumbers = GenerateNumbersBasic(5, 1, 49);

            // display on labels
            Label[] labels = new Label[] { labelNum1, labelNum2, labelNum3, labelNum4, labelNum5 };
            for (int i = 0; i < 5; i++)
            {
                labels[i].Text = generatedNumbers[i].ToString();
                labels[i].Invalidate();
            }

            // clear previous matches
            lstMatches.Items.Clear();
            lblStatus.Text = "狀態：已產生號碼";
            UpdateControlStates();
        }

        private void btnLoadDraw_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            string path = openFileDialog1.FileName;

            try
            {
                if (!File.Exists(path))
                {
                    MessageBox.Show("檔案不存在。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var lines = new List<string>();
                using (var sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                            lines.Add(line.Trim());
                    }
                }

                if (lines.Count != 5)
                {
                    MessageBox.Show("檔案格式錯誤：檔案應包含 5 行，每行一個數字。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int[] nums = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    if (!int.TryParse(lines[i], out int v))
                    {
                        MessageBox.Show($"第 {i + 1} 行格式錯誤：無法轉為整數。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (v < 1 || v > 49)
                    {
                        MessageBox.Show($"第 {i + 1} 行數字超出範圍 (1-49)。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    nums[i] = v;
                }

                // 檢查重複
                for (int i = 0; i < 5; i++)
                {
                    for (int j = i + 1; j < 5; j++)
                    {
                        if (nums[i] == nums[j])
                        {
                            MessageBox.Show($"檔案格式錯誤：第 {i + 1} 與第 {j + 1} 行有重複數字。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                // assign and sort (simple bubble sort to use basic constructs)
                drawNumbers = new int[5];
                for (int i = 0; i < 5; i++) drawNumbers[i] = nums[i];

                // bubble sort
                for (int i = 0; i < 5 - 1; i++)
                {
                    for (int j = 0; j < 5 - 1 - i; j++)
                    {
                        if (drawNumbers[j] > drawNumbers[j + 1])
                        {
                            int t = drawNumbers[j];
                            drawNumbers[j] = drawNumbers[j + 1];
                            drawNumbers[j + 1] = t;
                        }
                    }
                }

                lstDraw.Items.Clear();
                for (int i = 0; i < 5; i++)
                    lstDraw.Items.Add(drawNumbers[i]);

                MessageBox.Show("開獎號碼讀取完成。", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblStatus.Text = "狀態：已讀取開獎號碼";
                UpdateControlStates();
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀取檔案失敗: " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            lstMatches.Items.Clear();

            if (generatedNumbers == null)
            {
                MessageBox.Show("請先產生號碼。", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (drawNumbers == null)
            {
                MessageBox.Show("請先讀取開獎號碼檔案。", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int[] matches = new int[5];
            int matchCount = 0;

            for (int i = 0; i < generatedNumbers.Length; i++)
            {
                for (int j = 0; j < drawNumbers.Length; j++)
                {
                    if (generatedNumbers[i] == drawNumbers[j])
                    {
                        matches[matchCount] = generatedNumbers[i];
                        matchCount++;
                        break;
                    }
                }
            }

            // sort matches (bubble)
            for (int i = 0; i < matchCount - 1; i++)
            {
                for (int j = 0; j < matchCount - 1 - i; j++)
                {
                    if (matches[j] > matches[j + 1])
                    {
                        int t = matches[j];
                        matches[j] = matches[j + 1];
                        matches[j + 1] = t;
                    }
                }
            }

            for (int i = 0; i < matchCount; i++)
                lstMatches.Items.Add(matches[i]);

            string prize = DeterminePrize(matchCount);
            lblStatus.Text = $"狀態：比對完成，共中 {matchCount} 個號碼，獎項：{prize}";
            MessageBox.Show($"比對完成，共中 {matchCount} 個號碼。獎項：{prize}", "結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 使用基本語法產生不重複亂數（陣列+迴圈+條件），避免使用進階資料結構
        private int[] GenerateNumbersBasic(int count, int min, int max)
        {
            int[] result = new int[count];
            int filled = 0;
            while (filled < count)
            {
                int candidate = rnd.Next(min, max + 1);
                bool exists = false;
                for (int i = 0; i < filled; i++)
                {
                    if (result[i] == candidate)
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    result[filled] = candidate;
                    filled++;
                }
            }

            // simple bubble sort
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - 1 - i; j++)
                {
                    if (result[j] > result[j + 1])
                    {
                        int t = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = t;
                    }
                }
            }

            return result;
        }

        private string DeterminePrize(int matchCount)
        {
            switch (matchCount)
            {
                case 5:
                    return "頭獎";
                case 4:
                    return "二獎";
                case 3:
                    return "三獎";
                case 2:
                    return "四獎";
                default:
                    return "未中獎";
            }
        }

        private void UpdateControlStates()
        {
            bool canCompare = (generatedNumbers != null && generatedNumbers.Length == 5) && (drawNumbers != null && drawNumbers.Length == 5);
            btnCompare.Enabled = canCompare;
        }

        private void LabelNum_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = sender as Label;
            if (lbl == null) return;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Rectangle r = new Rectangle(0, 0, lbl.Width - 1, lbl.Height - 1);
            Color back = Color.LightGray;
            Color fore = Color.Black;

            if (lbl.Text != "--")
            {
                // highlight if in draw numbers
                if (drawNumbers != null)
                {
                    int val;
                    if (int.TryParse(lbl.Text, out val))
                    {
                        for (int i = 0; i < drawNumbers.Length; i++)
                        {
                            if (val == drawNumbers[i])
                            {
                                back = Color.Orange;
                                fore = Color.White;
                                break;
                            }
                        }
                    }
                }
            }

            using (var b = new SolidBrush(back))
            {
                e.Graphics.FillEllipse(b, r);
            }
            using (var p = new Pen(Color.DarkGray, 2))
            {
                e.Graphics.DrawEllipse(p, r);
            }

            // draw text centered
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine;
            TextRenderer.DrawText(e.Graphics, lbl.Text, lbl.Font, r, fore, flags);
        }
    }
}
