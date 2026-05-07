namespace 吃角子老虎機遊戲
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        private int n1, n2, n3;
        private int prize = 0;
        private int balance = 0;
        private int totalDeposited = 0;
        private int totalSpins = 0;
        private int winCount = 0;

        private System.Windows.Forms.Timer spinTimer;
        private int spinTick = 0;
        private int lastBet = 0;
        private bool pb1Stopped = false;
        private bool pb2Stopped = false;
        private bool pb3Stopped = false;
        private const int TICKS_STOP_PB1 = 10;
        private const int TICKS_STOP_PB2 = 17;
        private const int TICKS_STOP_PB3 = 24;

        public Form1()
        {
            InitializeComponent();
            spinTimer = new System.Windows.Forms.Timer();
            spinTimer.Interval = 80;
            spinTimer.Tick += spinTimer_Tick;
            LoadImages();
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            SaveGame();
        }

        private void SaveGame()
        {
            try
            {
                string path = System.IO.Path.Combine(Application.StartupPath, "savegame.txt");
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(path))
                {
                    writer.WriteLine($"balance={balance}");
                    writer.WriteLine($"totalDeposited={totalDeposited}");
                    writer.WriteLine($"totalSpins={totalSpins}");
                    writer.WriteLine($"winCount={winCount}");
                }
            }
            catch
            {
                // 寫入失敗時靜默忽略
            }
        }

        private void LoadGame()
        {
            try
            {
                string path = System.IO.Path.Combine(Application.StartupPath, "savegame.txt");
                if (System.IO.File.Exists(path))
                {
                    string[] lines = System.IO.File.ReadAllLines(path);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('=');
                        if (parts.Length == 2)
                        {
                            string key = parts[0].Trim();
                            if (int.TryParse(parts[1].Trim(), out int value))
                            {
                                switch (key)
                                {
                                    case "balance": balance = value; break;
                                    case "totalDeposited": totalDeposited = value; break;
                                    case "totalSpins": totalSpins = value; break;
                                    case "winCount": winCount = value; break;
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                balance = 0;
                totalDeposited = 0;
                totalSpins = 0;
                winCount = 0;
            }
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            LoadGame();

            // 設定下注金額選項及預設值
            comboBox_bet.Items.AddRange(new string[] { "$1", "$5", "$10", "$50" });
            comboBox_bet.SelectedIndex = 0; // 預設 $1

            // 顯示統計標籤
            label_totalSpins.Visible = true;
            label_winCount.Visible = true;
            label_winRate.Visible = true;

            // 初始介面狀態更新
            UpdateUI();
            UpdateStats();

            // 程式啟動：顯示初始圖片 (已在 LoadImages 中實現第一張圖片的顯示，這裡可額外做整理)
            getImage(true);
        }

        private void button_deposit_Click(object? sender, EventArgs e)
        {
            if (int.TryParse(textBox_deposit.Text, out int amount) && amount > 0)
            {
                balance += amount;
                totalDeposited += amount;
                textBox_deposit.Clear();
                UpdateUI();
                SaveGame();
            }
            else
            {
                MessageBox.Show("請輸入有效的存入金額（必須為正整數）");
            }
        }

        private int GetBetAmount()
        {
            if (comboBox_bet.SelectedItem == null) return 1;
            string betStr = comboBox_bet.SelectedItem.ToString()!.Replace("$", "");
            int.TryParse(betStr, out int bet);
            return bet;
        }

        private void comboBox_bet_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (spinTimer != null && spinTimer.Enabled) return;
            // 切換下注金額，重新判斷旋轉按鈕是否可用
            UpdateUI();
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            if (spinTimer != null && spinTimer.Enabled) return;

            int bet = GetBetAmount();
            if (balance < bet) return;

            // 扣除下注金額及增加旋轉次數
            balance -= bet;
            totalSpins++;

            // 預先決定 n1, n2, n3
            int imgCount = imageList1.Images.Count > 0 ? imageList1.Images.Count : 10;
            n1 = rand.Next(imgCount);
            n2 = rand.Next(imgCount);
            n3 = rand.Next(imgCount);

            // 重置狀態
            lastBet = bet;
            spinTick = 0;
            pb1Stopped = false;
            pb2Stopped = false;
            pb3Stopped = false;
            prize = 0; // 重置獎金顯示

            UpdateUI(); // 更新餘額並關閉按鈕

            // 啟動轉動動畫
            spinTimer.Start();
        }

        private void spinTimer_Tick(object? sender, EventArgs e)
        {
            spinTick++;
            int imgCount = imageList1.Images.Count > 0 ? imageList1.Images.Count : 10;

            if (imageList1.Images.Count > 0)
            {
                if (!pb1Stopped) pictureBox1.Image = imageList1.Images[rand.Next(imgCount)];
                if (!pb2Stopped) pictureBox2.Image = imageList1.Images[rand.Next(imgCount)];
                if (!pb3Stopped) pictureBox3.Image = imageList1.Images[rand.Next(imgCount)];
            }

            if (spinTick >= TICKS_STOP_PB1 && !pb1Stopped)
            {
                pb1Stopped = true;
                if (imageList1.Images.Count > 0) pictureBox1.Image = imageList1.Images[n1];
            }

            if (spinTick >= TICKS_STOP_PB2 && !pb2Stopped)
            {
                pb2Stopped = true;
                if (imageList1.Images.Count > 0) pictureBox2.Image = imageList1.Images[n2];
            }

            if (spinTick >= TICKS_STOP_PB3 && !pb3Stopped)
            {
                pb3Stopped = true;
                if (imageList1.Images.Count > 0) pictureBox3.Image = imageList1.Images[n3];
                
                spinTimer.Stop();
                
                // 執行勝負判斷 → 更新統計 → 更新介面
                checkWinner(lastBet);
                UpdateUI();
                UpdateStats();
                SaveGame();
            }
        }

        private void button2_Click(object? sender, EventArgs e)
        {
            int netGain = balance - totalDeposited;
            string gainLossText = netGain >= 0 ? $"淨賺：{netGain.ToString("c")}" : $"虧損：{Math.Abs(netGain).ToString("c")}";

            string msg = $"累計存入：{totalDeposited.ToString("c")}\n" +
                         $"目前餘額：{balance.ToString("c")}\n" +
                         $"{gainLossText}\n\n" +
                         $"旋轉次數：{totalSpins} 次　中獎次數：{winCount} 次";

            MessageBox.Show(msg, "遊戲結算", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void getImage(bool isInit)
        {
            int imgCount = imageList1.Images.Count > 0 ? imageList1.Images.Count : 10;

            if (isInit)
            {
                n1 = 0; n2 = 0; n3 = 0; // 初始預設皆為 0
            }
            else
            {
                n1 = rand.Next(imgCount);
                n2 = rand.Next(imgCount);
                n3 = rand.Next(imgCount);
            }

            if (imageList1.Images.Count > 0)
            {
                pictureBox1.Image = imageList1.Images[n1];
                pictureBox2.Image = imageList1.Images[n2];
                pictureBox3.Image = imageList1.Images[n3];
            }
        }

        private void checkWinner(int bet)
        {
            prize = 0;
            if (n1 == n2 && n2 == n3)
            {
                prize = bet * 10; // 頭獎
            }
            else if (n1 == n2 || n1 == n3 || n2 == n3)
            {
                prize = bet * 2; // 普獎
            }

            if (prize > 0)
            {
                winCount++;
            }

            // 加回獎金
            balance += prize;
        }

        private void UpdateUI()
        {
            label_balance.Text = "餘額：" + balance.ToString("c");
            label_lastWin.Text = "本次獲得：" + prize.ToString("c");

            if (spinTimer != null && spinTimer.Enabled)
            {
                button1.Enabled = false;
                return;
            }

            int bet = GetBetAmount();
            button1.Enabled = (balance >= bet);
        }

        private void UpdateStats()
        {
            label_totalSpins.Text = $"旋轉：{totalSpins} 次";
            label_winCount.Text = $"中獎：{winCount} 次";

            double winRate = (totalSpins > 0) ? ((double)winCount / totalSpins) * 100 : 0.0;
            label_winRate.Text = $"勝率：{winRate:F1}%";
        }

        private void LoadImages()
        {
            // 將 10 種水果圖片載入 ImageList1
            string[] imageNames = { "Apple.bmp", "Banana.bmp", "Cherries.bmp", "Grapes.bmp", "Lemon.bmp", "Lime.bmp", "Orange.bmp", "Pear.bmp", "Strawberry.bmp", "Watermelon.bmp" };

            try
            {
                string directoryPath = System.IO.Path.Combine(Application.StartupPath, "Fruit Symbols");
                
                foreach (string name in imageNames)
                {
                    string path = System.IO.Path.Combine(directoryPath, name);
                    if (System.IO.File.Exists(path))
                    {
                        imageList1.Images.Add(Image.FromFile(path));
                    }
                }

                // 預設設定起始圖片 (例如隨機或設定為第一張圖片)
                if (imageList1.Images.Count > 0)
                {
                    pictureBox1.Image = imageList1.Images[0];
                    pictureBox2.Image = imageList1.Images[0];
                    pictureBox3.Image = imageList1.Images[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("載入圖片發生錯誤: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
