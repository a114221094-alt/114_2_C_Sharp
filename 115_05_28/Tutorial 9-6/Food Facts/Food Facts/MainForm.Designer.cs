namespace Food_Facts
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.muffinRadioButton = new System.Windows.Forms.RadioButton();
            this.popcornRadioButton = new System.Windows.Forms.RadioButton();
            this.bananaRadioButton = new System.Windows.Forms.RadioButton();
            this.displayButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.muffinRadioButton);
            this.groupBox1.Controls.Add(this.popcornRadioButton);
            this.groupBox1.Controls.Add(this.bananaRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "選擇食物";
            // 
            // muffinRadioButton
            // 
            this.muffinRadioButton.AutoSize = true;
            this.muffinRadioButton.Location = new System.Drawing.Point(30, 140);
            this.muffinRadioButton.Name = "muffinRadioButton";
            this.muffinRadioButton.Size = new System.Drawing.Size(201, 34);
            this.muffinRadioButton.TabIndex = 2;
            this.muffinRadioButton.TabStop = true;
            this.muffinRadioButton.Text = "1 個大藍莓瑪芬";
            this.muffinRadioButton.UseVisualStyleBackColor = true;
            // 
            // popcornRadioButton
            // 
            this.popcornRadioButton.AutoSize = true;
            this.popcornRadioButton.Location = new System.Drawing.Point(30, 90);
            this.popcornRadioButton.Name = "popcornRadioButton";
            this.popcornRadioButton.Size = new System.Drawing.Size(177, 34);
            this.popcornRadioButton.TabIndex = 1;
            this.popcornRadioButton.TabStop = true;
            this.popcornRadioButton.Text = "1 杯氣炸爆米花";
            this.popcornRadioButton.UseVisualStyleBackColor = true;
            // 
            // bananaRadioButton
            // 
            this.bananaRadioButton.AutoSize = true;
            this.bananaRadioButton.Location = new System.Drawing.Point(30, 40);
            this.bananaRadioButton.Name = "bananaRadioButton";
            this.bananaRadioButton.Size = new System.Drawing.Size(105, 34);
            this.bananaRadioButton.TabIndex = 0;
            this.bananaRadioButton.TabStop = true;
            this.bananaRadioButton.Text = "1 根香蕉";
            this.bananaRadioButton.UseVisualStyleBackColor = true;
            // 
            // displayButton
            // 
            this.displayButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.displayButton.Location = new System.Drawing.Point(40, 240);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(220, 50);
            this.displayButton.TabIndex = 1;
            this.displayButton.Text = "顯示食物營養資訊";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(290, 240);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 50);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 320);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "MainForm";
            this.Text = "食物營養資訊";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton muffinRadioButton;
        private System.Windows.Forms.RadioButton popcornRadioButton;
        private System.Windows.Forms.RadioButton bananaRadioButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button exitButton;
    }
}

