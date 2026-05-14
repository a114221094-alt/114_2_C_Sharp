namespace Cell_Phone_Test
{
    partial class Form1
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
            this.exitButton = new System.Windows.Forms.Button();
            this.createObjectButton = new System.Windows.Forms.Button();
            this.objectPropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.outputPriceLabel = new System.Windows.Forms.Label();
            this.outputModelLabel = new System.Windows.Forms.Label();
            this.outputBrandLabel = new System.Windows.Forms.Label();
            this.enterDataGroupBox = new System.Windows.Forms.GroupBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.promptPriceLabel = new System.Windows.Forms.Label();
            this.promptModelLabel = new System.Windows.Forms.Label();
            this.promptBrandLabel = new System.Windows.Forms.Label();
            this.objectPropertiesGroupBox.SuspendLayout();
            this.enterDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            // 離開按鈕：設定字型及繁體中文名稱並調整位置與大小
            this.exitButton.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(260, 520);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 60);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // createObjectButton
            // 
            // 建立物件按鈕：設定字型及繁體中文名稱並調整位置與大小
            this.createObjectButton.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.createObjectButton.Location = new System.Drawing.Point(80, 520);
            this.createObjectButton.Name = "createObjectButton";
            this.createObjectButton.Size = new System.Drawing.Size(150, 60);
            this.createObjectButton.TabIndex = 6;
            this.createObjectButton.Text = "建立物件";
            this.createObjectButton.UseVisualStyleBackColor = true;
            this.createObjectButton.Click += new System.EventHandler(this.createObjectButton_Click);
            // 
            // objectPropertiesGroupBox
            // 
            // 物件屬性群組方塊：設定字型及繁體中文名稱並調整位置與大小
            this.objectPropertiesGroupBox.Controls.Add(this.priceLabel);
            this.objectPropertiesGroupBox.Controls.Add(this.modelLabel);
            this.objectPropertiesGroupBox.Controls.Add(this.brandLabel);
            this.objectPropertiesGroupBox.Controls.Add(this.outputPriceLabel);
            this.objectPropertiesGroupBox.Controls.Add(this.outputModelLabel);
            this.objectPropertiesGroupBox.Controls.Add(this.outputBrandLabel);
            this.objectPropertiesGroupBox.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.objectPropertiesGroupBox.Location = new System.Drawing.Point(40, 270);
            this.objectPropertiesGroupBox.Name = "objectPropertiesGroupBox";
            this.objectPropertiesGroupBox.Size = new System.Drawing.Size(420, 220);
            this.objectPropertiesGroupBox.TabIndex = 5;
            this.objectPropertiesGroupBox.TabStop = false;
            this.objectPropertiesGroupBox.Text = "物件屬性";
            // 
            // priceLabel
            // 
            // 顯示價格標籤：調整位置與大小
            this.priceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceLabel.Location = new System.Drawing.Point(130, 150);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(250, 40);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modelLabel
            // 
            // 顯示型號標籤：調整位置與大小
            this.modelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modelLabel.Location = new System.Drawing.Point(130, 95);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(250, 40);
            this.modelLabel.TabIndex = 6;
            this.modelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brandLabel
            // 
            // 顯示品牌標籤：調整位置與大小
            this.brandLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.brandLabel.Location = new System.Drawing.Point(130, 40);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(250, 40);
            this.brandLabel.TabIndex = 4;
            this.brandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputPriceLabel
            // 
            // 價格提示標籤：設定繁體中文與位置
            this.outputPriceLabel.AutoSize = true;
            this.outputPriceLabel.Location = new System.Drawing.Point(20, 158);
            this.outputPriceLabel.Name = "outputPriceLabel";
            this.outputPriceLabel.Size = new System.Drawing.Size(58, 24);
            this.outputPriceLabel.TabIndex = 5;
            this.outputPriceLabel.Text = "價格:";
            // 
            // outputModelLabel
            // 
            // 型號提示標籤：設定繁體中文與位置
            this.outputModelLabel.AutoSize = true;
            this.outputModelLabel.Location = new System.Drawing.Point(20, 103);
            this.outputModelLabel.Name = "outputModelLabel";
            this.outputModelLabel.Size = new System.Drawing.Size(58, 24);
            this.outputModelLabel.TabIndex = 4;
            this.outputModelLabel.Text = "型號:";
            // 
            // outputBrandLabel
            // 
            // 品牌提示標籤：設定繁體中文與位置
            this.outputBrandLabel.AutoSize = true;
            this.outputBrandLabel.Location = new System.Drawing.Point(20, 48);
            this.outputBrandLabel.Name = "outputBrandLabel";
            this.outputBrandLabel.Size = new System.Drawing.Size(58, 24);
            this.outputBrandLabel.TabIndex = 3;
            this.outputBrandLabel.Text = "品牌:";
            // 
            // enterDataGroupBox
            // 
            // 輸入框群組：設定字型及繁體中文名稱並調整位置與大小
            this.enterDataGroupBox.Controls.Add(this.priceTextBox);
            this.enterDataGroupBox.Controls.Add(this.modelTextBox);
            this.enterDataGroupBox.Controls.Add(this.brandTextBox);
            this.enterDataGroupBox.Controls.Add(this.promptPriceLabel);
            this.enterDataGroupBox.Controls.Add(this.promptModelLabel);
            this.enterDataGroupBox.Controls.Add(this.promptBrandLabel);
            this.enterDataGroupBox.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.enterDataGroupBox.Location = new System.Drawing.Point(40, 20);
            this.enterDataGroupBox.Name = "enterDataGroupBox";
            this.enterDataGroupBox.Size = new System.Drawing.Size(420, 220);
            this.enterDataGroupBox.TabIndex = 4;
            this.enterDataGroupBox.TabStop = false;
            this.enterDataGroupBox.Text = "輸入手機資料";
            // 
            // priceTextBox
            // 
            // 價格輸入框：調整位置與大小
            this.priceTextBox.Location = new System.Drawing.Point(130, 150);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(250, 36);
            this.priceTextBox.TabIndex = 5;
            // 
            // modelTextBox
            // 
            // 型號輸入框：調整位置與大小
            this.modelTextBox.Location = new System.Drawing.Point(130, 95);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(250, 36);
            this.modelTextBox.TabIndex = 4;
            // 
            // brandTextBox
            // 
            // 品牌輸入框：調整位置與大小
            this.brandTextBox.Location = new System.Drawing.Point(130, 40);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(250, 36);
            this.brandTextBox.TabIndex = 3;
            // 
            // promptPriceLabel
            // 
            // 價格提示：設定繁體中文與位置
            this.promptPriceLabel.AutoSize = true;
            this.promptPriceLabel.Location = new System.Drawing.Point(20, 155);
            this.promptPriceLabel.Name = "promptPriceLabel";
            this.promptPriceLabel.Size = new System.Drawing.Size(58, 24);
            this.promptPriceLabel.TabIndex = 2;
            this.promptPriceLabel.Text = "價格:";
            // 
            // promptModelLabel
            // 
            // 型號提示：設定繁體中文與位置
            this.promptModelLabel.AutoSize = true;
            this.promptModelLabel.Location = new System.Drawing.Point(20, 100);
            this.promptModelLabel.Name = "promptModelLabel";
            this.promptModelLabel.Size = new System.Drawing.Size(58, 24);
            this.promptModelLabel.TabIndex = 1;
            this.promptModelLabel.Text = "型號:";
            // 
            // promptBrandLabel
            // 
            // 品牌提示：設定繁體中文與位置
            this.promptBrandLabel.AutoSize = true;
            this.promptBrandLabel.Location = new System.Drawing.Point(20, 45);
            this.promptBrandLabel.Name = "promptBrandLabel";
            this.promptBrandLabel.Size = new System.Drawing.Size(58, 24);
            this.promptBrandLabel.TabIndex = 0;
            this.promptBrandLabel.Text = "品牌:";
            // 
            // Form1
            // 
            // 視窗主體：調整大小及標題
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createObjectButton);
            this.Controls.Add(this.objectPropertiesGroupBox);
            this.Controls.Add(this.enterDataGroupBox);
            this.Name = "Form1";
            this.Text = "手機測試";
            this.objectPropertiesGroupBox.ResumeLayout(false);
            this.objectPropertiesGroupBox.PerformLayout();
            this.enterDataGroupBox.ResumeLayout(false);
            this.enterDataGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button createObjectButton;
        private System.Windows.Forms.GroupBox objectPropertiesGroupBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label outputPriceLabel;
        private System.Windows.Forms.Label outputModelLabel;
        private System.Windows.Forms.Label outputBrandLabel;
        private System.Windows.Forms.GroupBox enterDataGroupBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.Label promptPriceLabel;
        private System.Windows.Forms.Label promptModelLabel;
        private System.Windows.Forms.Label promptBrandLabel;
    }
}

