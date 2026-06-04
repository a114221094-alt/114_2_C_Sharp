namespace Tutorial_9_3_3
{
    partial class MainForm
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
            buttonOpenAccount = new Button();
            buttonDeposit = new Button();
            buttonWithdraw = new Button();
            buttonExit = new Button();
            labelAccountCount = new Label();
            SuspendLayout();
            // 
            // buttonOpenAccount
            // 
            buttonOpenAccount.Location = new Point(53, 69);
            buttonOpenAccount.Margin = new Padding(5);
            buttonOpenAccount.Name = "buttonOpenAccount";
            buttonOpenAccount.Size = new Size(189, 92);
            buttonOpenAccount.TabIndex = 0;
            buttonOpenAccount.Text = "開戶";
            buttonOpenAccount.UseVisualStyleBackColor = true;
            buttonOpenAccount.Click += buttonOpenAccount_Click;
            // 
            // buttonDeposit
            // 
            buttonDeposit.Location = new Point(396, 69);
            buttonDeposit.Margin = new Padding(5);
            buttonDeposit.Name = "buttonDeposit";
            buttonDeposit.Size = new Size(189, 92);
            buttonDeposit.TabIndex = 1;
            buttonDeposit.Text = "存款";
            buttonDeposit.UseVisualStyleBackColor = true;
            buttonDeposit.Click += buttonDeposit_Click;
            // 
            // buttonWithdraw
            // 
            buttonWithdraw.Location = new Point(715, 69);
            buttonWithdraw.Margin = new Padding(5);
            buttonWithdraw.Name = "buttonWithdraw";
            buttonWithdraw.Size = new Size(189, 92);
            buttonWithdraw.TabIndex = 2;
            buttonWithdraw.Text = "提款";
            buttonWithdraw.UseVisualStyleBackColor = true;
            buttonWithdraw.Click += buttonWithdraw_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(396, 263);
            buttonExit.Margin = new Padding(5);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(189, 92);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "離開";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // labelAccountCount
            // 
            labelAccountCount.AutoSize = true;
            labelAccountCount.Location = new Point(53, 297);
            labelAccountCount.Name = "labelAccountCount";
            labelAccountCount.Size = new Size(128, 23);
            labelAccountCount.TabIndex = 4;
            labelAccountCount.Text = "已開戶人數：0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 515);
            Controls.Add(labelAccountCount);
            Controls.Add(buttonExit);
            Controls.Add(buttonWithdraw);
            Controls.Add(buttonDeposit);
            Controls.Add(buttonOpenAccount);
            Margin = new Padding(5);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonOpenAccount;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelAccountCount;
    }
}
