namespace 吃角子老虎機遊戲
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label_depositPrompt = new Label();
            textBox_deposit = new TextBox();
            button_deposit = new Button();
            label_balance = new Label();
            label_lastWin = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label_betPrompt = new Label();
            comboBox_bet = new ComboBox();
            label_totalSpins = new Label();
            label_winCount = new Label();
            label_winRate = new Label();
            button1 = new Button();
            button2 = new Button();
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label_depositPrompt
            // 
            label_depositPrompt.AutoSize = true;
            label_depositPrompt.Location = new Point(50, 40);
            label_depositPrompt.Name = "label_depositPrompt";
            label_depositPrompt.Size = new Size(221, 45);
            label_depositPrompt.TabIndex = 0;
            label_depositPrompt.Text = "存入金額：$";
            // 
            // textBox_deposit
            // 
            textBox_deposit.Location = new Point(264, 35);
            textBox_deposit.Name = "textBox_deposit";
            textBox_deposit.Size = new Size(150, 55);
            textBox_deposit.TabIndex = 1;
            // 
            // button_deposit
            // 
            button_deposit.Location = new Point(444, 35);
            button_deposit.Name = "button_deposit";
            button_deposit.Size = new Size(129, 55);
            button_deposit.TabIndex = 2;
            button_deposit.Text = "存入";
            button_deposit.UseVisualStyleBackColor = true;
            button_deposit.Click += button_deposit_Click;
            // 
            // label_balance
            // 
            label_balance.AutoSize = true;
            label_balance.Location = new Point(50, 90);
            label_balance.Name = "label_balance";
            label_balance.Size = new Size(269, 45);
            label_balance.TabIndex = 3;
            label_balance.Text = "餘額：NT$0.00";
            // 
            // label_lastWin
            // 
            label_lastWin.AutoSize = true;
            label_lastWin.Location = new Point(308, 95);
            label_lastWin.Name = "label_lastWin";
            label_lastWin.Size = new Size(341, 45);
            label_lastWin.TabIndex = 4;
            label_lastWin.Text = "本次獲得：NT$0.00";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(50, 158);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(199, 158);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(347, 158);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(120, 120);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label_betPrompt
            // 
            label_betPrompt.AutoSize = true;
            label_betPrompt.Location = new Point(50, 300);
            label_betPrompt.Name = "label_betPrompt";
            label_betPrompt.Size = new Size(200, 45);
            label_betPrompt.TabIndex = 8;
            label_betPrompt.Text = "下注金額：";
            // 
            // comboBox_bet
            // 
            comboBox_bet.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_bet.FormattingEnabled = true;
            comboBox_bet.Location = new Point(240, 300);
            comboBox_bet.Name = "comboBox_bet";
            comboBox_bet.Size = new Size(120, 53);
            comboBox_bet.TabIndex = 9;
            comboBox_bet.SelectedIndexChanged += comboBox_bet_SelectedIndexChanged;
            // 
            // label_totalSpins
            // 
            label_totalSpins.AutoSize = true;
            label_totalSpins.Font = new Font("微軟正黑體", 12F);
            label_totalSpins.Location = new Point(72, 360);
            label_totalSpins.Name = "label_totalSpins";
            label_totalSpins.Size = new Size(153, 30);
            label_totalSpins.TabIndex = 12;
            label_totalSpins.Text = "總旋轉：0 次";
            label_totalSpins.Visible = false;
            // 
            // label_winCount
            // 
            label_winCount.AutoSize = true;
            label_winCount.Font = new Font("微軟正黑體", 12F);
            label_winCount.Location = new Point(231, 360);
            label_winCount.Name = "label_winCount";
            label_winCount.Size = new Size(129, 30);
            label_winCount.TabIndex = 13;
            label_winCount.Text = "中獎：0 次";
            label_winCount.Visible = false;
            // 
            // label_winRate
            // 
            label_winRate.AutoSize = true;
            label_winRate.Font = new Font("微軟正黑體", 12F);
            label_winRate.Location = new Point(363, 360);
            label_winRate.Name = "label_winRate";
            label_winRate.Size = new Size(120, 30);
            label_winRate.TabIndex = 14;
            label_winRate.Text = "勝率：0%";
            label_winRate.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(130, 404);
            button1.Name = "button1";
            button1.Size = new Size(141, 55);
            button1.TabIndex = 10;
            button1.Text = "旋轉";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(294, 404);
            button2.Name = "button2";
            button2.Size = new Size(138, 55);
            button2.TabIndex = 11;
            button2.Text = "離開";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(120, 120);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(697, 510);
            Controls.Add(label_winRate);
            Controls.Add(label_winCount);
            Controls.Add(label_totalSpins);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox_bet);
            Controls.Add(label_betPrompt);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label_lastWin);
            Controls.Add(label_balance);
            Controls.Add(button_deposit);
            Controls.Add(textBox_deposit);
            Controls.Add(label_depositPrompt);
            Font = new Font("微軟正黑體", 18F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "吃角子老虎機";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label_depositPrompt;
        private System.Windows.Forms.TextBox textBox_deposit;
        private System.Windows.Forms.Button button_deposit;
        private System.Windows.Forms.Label label_balance;
        private System.Windows.Forms.Label label_lastWin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label_betPrompt;
        private System.Windows.Forms.ComboBox comboBox_bet;
        private System.Windows.Forms.Label label_totalSpins;
        private System.Windows.Forms.Label label_winCount;
        private System.Windows.Forms.Label label_winRate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
    }
}
