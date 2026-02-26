namespace Q2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // UI control fields
        private System.Windows.Forms.GroupBox groupBoxOilLube;
        private System.Windows.Forms.CheckBox chkOilChange;
        private System.Windows.Forms.CheckBox chkLubrication;
        private System.Windows.Forms.GroupBox groupBoxFlushes;
        private System.Windows.Forms.CheckBox chkRadiatorCleaning;
        private System.Windows.Forms.CheckBox chkTransmissionCleaning;
        private System.Windows.Forms.GroupBox groupBoxMisc;
        private System.Windows.Forms.CheckBox chkInspection;
        private System.Windows.Forms.CheckBox chkMufflerReplacement;
        private System.Windows.Forms.CheckBox chkTireRotation;

        private System.Windows.Forms.GroupBox groupBoxPartsAndLabor;
        private System.Windows.Forms.Label labelParts;
        private System.Windows.Forms.TextBox textBoxPartsInput;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.TextBox textBoxHoursInput;

        private System.Windows.Forms.GroupBox groupBoxFeeSummary;
        private System.Windows.Forms.Label labelSummaryService;
        private System.Windows.Forms.TextBox textBoxServiceLabor;
        private System.Windows.Forms.Label labelSummaryParts;
        private System.Windows.Forms.TextBox textBoxParts;
        private System.Windows.Forms.Label labelSummaryTax;
        private System.Windows.Forms.TextBox textBoxTax;
        private System.Windows.Forms.Label labelSummaryTotal;
        private System.Windows.Forms.TextBox textBoxTotal;

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClearShort;
        private System.Windows.Forms.Button buttonExit;

        private System.Windows.Forms.DataGridView dataGridViewRecords;

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
            this.components = new System.ComponentModel.Container();
            this.groupBoxOilLube = new System.Windows.Forms.GroupBox();
            this.chkOilChange = new System.Windows.Forms.CheckBox();
            this.chkLubrication = new System.Windows.Forms.CheckBox();
            this.groupBoxFlushes = new System.Windows.Forms.GroupBox();
            this.chkRadiatorCleaning = new System.Windows.Forms.CheckBox();
            this.chkTransmissionCleaning = new System.Windows.Forms.CheckBox();
            this.groupBoxMisc = new System.Windows.Forms.GroupBox();
            this.chkInspection = new System.Windows.Forms.CheckBox();
            this.chkMufflerReplacement = new System.Windows.Forms.CheckBox();
            this.chkTireRotation = new System.Windows.Forms.CheckBox();

            this.groupBoxPartsAndLabor = new System.Windows.Forms.GroupBox();
            this.labelParts = new System.Windows.Forms.Label();
            this.textBoxPartsInput = new System.Windows.Forms.TextBox();
            this.labelHours = new System.Windows.Forms.Label();
            this.textBoxHoursInput = new System.Windows.Forms.TextBox();

            this.groupBoxFeeSummary = new System.Windows.Forms.GroupBox();
            this.labelSummaryService = new System.Windows.Forms.Label();
            this.textBoxServiceLabor = new System.Windows.Forms.TextBox();
            this.labelSummaryParts = new System.Windows.Forms.Label();
            this.textBoxParts = new System.Windows.Forms.TextBox();
            this.labelSummaryTax = new System.Windows.Forms.Label();
            this.textBoxTax = new System.Windows.Forms.TextBox();
            this.labelSummaryTotal = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();

            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClearShort = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();

            // instantiate dataGridViewRecords so BeginInit/EndInit are valid
            this.dataGridViewRecords = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOilLube
            // 
            this.groupBoxOilLube.Controls.Add(this.chkOilChange);
            this.groupBoxOilLube.Controls.Add(this.chkLubrication);
            this.groupBoxOilLube.Location = new System.Drawing.Point(12, 12);
            this.groupBoxOilLube.Name = "groupBoxOilLube";
            this.groupBoxOilLube.Size = new System.Drawing.Size(200, 80);
            this.groupBoxOilLube.TabIndex = 0;
            this.groupBoxOilLube.TabStop = false;
            this.groupBoxOilLube.Text = "機油和潤滑";
            // 
            // chkOilChange
            // 
            this.chkOilChange.AutoSize = true;
            this.chkOilChange.Location = new System.Drawing.Point(10, 22);
            this.chkOilChange.Name = "chkOilChange";
            this.chkOilChange.Size = new System.Drawing.Size(160, 19);
            this.chkOilChange.TabIndex = 0;
            this.chkOilChange.Text = "更換機油 (NT$780)";
            this.chkOilChange.UseVisualStyleBackColor = true;
            // 
            // chkLubrication
            // 
            this.chkLubrication.AutoSize = true;
            this.chkLubrication.Location = new System.Drawing.Point(10, 45);
            this.chkLubrication.Name = "chkLubrication";
            this.chkLubrication.Size = new System.Drawing.Size(160, 19);
            this.chkLubrication.TabIndex = 1;
            this.chkLubrication.Text = "潤滑保養 (NT$540)";
            this.chkLubrication.UseVisualStyleBackColor = true;
            // 
            // groupBoxFlushes
            // 
            this.groupBoxFlushes.Controls.Add(this.chkRadiatorCleaning);
            this.groupBoxFlushes.Controls.Add(this.chkTransmissionCleaning);
            this.groupBoxFlushes.Location = new System.Drawing.Point(220, 12);
            this.groupBoxFlushes.Name = "groupBoxFlushes";
            this.groupBoxFlushes.Size = new System.Drawing.Size(220, 80);
            this.groupBoxFlushes.TabIndex = 1;
            this.groupBoxFlushes.TabStop = false;
            this.groupBoxFlushes.Text = "清洗服務";
            // 
            // chkRadiatorCleaning
            // 
            this.chkRadiatorCleaning.AutoSize = true;
            this.chkRadiatorCleaning.Location = new System.Drawing.Point(10, 22);
            this.chkRadiatorCleaning.Name = "chkRadiatorCleaning";
            this.chkRadiatorCleaning.Size = new System.Drawing.Size(150, 19);
            this.chkRadiatorCleaning.TabIndex = 0;
            this.chkRadiatorCleaning.Text = "水箱清洗 (NT$900)";
            this.chkRadiatorCleaning.UseVisualStyleBackColor = true;
            // 
            // chkTransmissionCleaning
            // 
            this.chkTransmissionCleaning.AutoSize = true;
            this.chkTransmissionCleaning.Location = new System.Drawing.Point(10, 45);
            this.chkTransmissionCleaning.Name = "chkTransmissionCleaning";
            this.chkTransmissionCleaning.Size = new System.Drawing.Size(170, 19);
            this.chkTransmissionCleaning.TabIndex = 1;
            this.chkTransmissionCleaning.Text = "變速箱清洗 (NT$2,400)";
            this.chkTransmissionCleaning.UseVisualStyleBackColor = true;
            // 
            // groupBoxMisc
            // 
            this.groupBoxMisc.Controls.Add(this.chkInspection);
            this.groupBoxMisc.Controls.Add(this.chkMufflerReplacement);
            this.groupBoxMisc.Controls.Add(this.chkTireRotation);
            this.groupBoxMisc.Location = new System.Drawing.Point(12, 100);
            this.groupBoxMisc.Name = "groupBoxMisc";
            this.groupBoxMisc.Size = new System.Drawing.Size(200, 110);
            this.groupBoxMisc.TabIndex = 2;
            this.groupBoxMisc.TabStop = false;
            this.groupBoxMisc.Text = "其他服務";
            // 
            // chkInspection
            // 
            this.chkInspection.AutoSize = true;
            this.chkInspection.Location = new System.Drawing.Point(10, 22);
            this.chkInspection.Name = "chkInspection";
            this.chkInspection.Size = new System.Drawing.Size(140, 19);
            this.chkInspection.TabIndex = 0;
            this.chkInspection.Text = "檢驗 (NT$450)";
            this.chkInspection.UseVisualStyleBackColor = true;
            // 
            // chkMufflerReplacement
            // 
            this.chkMufflerReplacement.AutoSize = true;
            this.chkMufflerReplacement.Location = new System.Drawing.Point(10, 45);
            this.chkMufflerReplacement.Name = "chkMufflerReplacement";
            this.chkMufflerReplacement.Size = new System.Drawing.Size(160, 19);
            this.chkMufflerReplacement.TabIndex = 1;
            this.chkMufflerReplacement.Text = "更換消音器 (NT$3,000)";
            this.chkMufflerReplacement.UseVisualStyleBackColor = true;
            // 
            // chkTireRotation
            // 
            this.chkTireRotation.AutoSize = true;
            this.chkTireRotation.Location = new System.Drawing.Point(10, 68);
            this.chkTireRotation.Name = "chkTireRotation";
            this.chkTireRotation.Size = new System.Drawing.Size(140, 19);
            this.chkTireRotation.TabIndex = 2;
            this.chkTireRotation.Text = "輪胎換位 (NT$600)";
            this.chkTireRotation.UseVisualStyleBackColor = true;

            // 
            // groupBoxPartsAndLabor
            // 
            this.groupBoxPartsAndLabor.Controls.Add(this.labelParts);
            this.groupBoxPartsAndLabor.Controls.Add(this.textBoxPartsInput);
            this.groupBoxPartsAndLabor.Controls.Add(this.labelHours);
            this.groupBoxPartsAndLabor.Controls.Add(this.textBoxHoursInput);
            this.groupBoxPartsAndLabor.Location = new System.Drawing.Point(220, 100);
            this.groupBoxPartsAndLabor.Name = "groupBoxPartsAndLabor";
            this.groupBoxPartsAndLabor.Size = new System.Drawing.Size(220, 110);
            this.groupBoxPartsAndLabor.TabIndex = 3;
            this.groupBoxPartsAndLabor.TabStop = false;
            this.groupBoxPartsAndLabor.Text = "零件和工時";
            // 
            // labelParts
            // 
            this.labelParts.AutoSize = true;
            this.labelParts.Location = new System.Drawing.Point(10, 25);
            this.labelParts.Name = "labelParts";
            this.labelParts.Size = new System.Drawing.Size(80, 15);
            this.labelParts.TabIndex = 0;
            this.labelParts.Text = "零件 (NT$)";
            // 
            // textBoxPartsInput
            // 
            this.textBoxPartsInput.Location = new System.Drawing.Point(100, 22);
            this.textBoxPartsInput.Name = "textBoxPartsInput";
            this.textBoxPartsInput.Size = new System.Drawing.Size(100, 23);
            this.textBoxPartsInput.TabIndex = 1;
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(10, 60);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(88, 15);
            this.labelHours.TabIndex = 2;
            this.labelHours.Text = "工時 (小時)";
            // 
            // textBoxHoursInput
            // 
            this.textBoxHoursInput.Location = new System.Drawing.Point(100, 57);
            this.textBoxHoursInput.Name = "textBoxHoursInput";
            this.textBoxHoursInput.Size = new System.Drawing.Size(100, 23);
            this.textBoxHoursInput.TabIndex = 3;

            // 
            // groupBoxFeeSummary
            // 
            this.groupBoxFeeSummary.Controls.Add(this.labelSummaryService);
            this.groupBoxFeeSummary.Controls.Add(this.textBoxServiceLabor);
            this.groupBoxFeeSummary.Controls.Add(this.labelSummaryParts);
            this.groupBoxFeeSummary.Controls.Add(this.textBoxParts);
            this.groupBoxFeeSummary.Controls.Add(this.labelSummaryTax);
            this.groupBoxFeeSummary.Controls.Add(this.textBoxTax);
            this.groupBoxFeeSummary.Controls.Add(this.labelSummaryTotal);
            this.groupBoxFeeSummary.Controls.Add(this.textBoxTotal);
            this.groupBoxFeeSummary.Location = new System.Drawing.Point(12, 220);
            this.groupBoxFeeSummary.Name = "groupBoxFeeSummary";
            this.groupBoxFeeSummary.Size = new System.Drawing.Size(320, 160);
            this.groupBoxFeeSummary.TabIndex = 4;
            this.groupBoxFeeSummary.TabStop = false;
            this.groupBoxFeeSummary.Text = "費用摘要";

            // 
            // labelSummaryService
            // 
            this.labelSummaryService.AutoSize = true;
            this.labelSummaryService.Location = new System.Drawing.Point(10, 28);
            this.labelSummaryService.Name = "labelSummaryService";
            this.labelSummaryService.Size = new System.Drawing.Size(88, 15);
            this.labelSummaryService.TabIndex = 0;
            this.labelSummaryService.Text = "服務與工資";
            // 
            // textBoxServiceLabor
            // 
            this.textBoxServiceLabor.Location = new System.Drawing.Point(140, 25);
            this.textBoxServiceLabor.Name = "textBoxServiceLabor";
            this.textBoxServiceLabor.ReadOnly = true;
            this.textBoxServiceLabor.Size = new System.Drawing.Size(160, 23);
            this.textBoxServiceLabor.TabIndex = 1;

            // 
            // labelSummaryParts
            // 
            this.labelSummaryParts.AutoSize = true;
            this.labelSummaryParts.Location = new System.Drawing.Point(10, 58);
            this.labelSummaryParts.Name = "labelSummaryParts";
            this.labelSummaryParts.Size = new System.Drawing.Size(40, 15);
            this.labelSummaryParts.TabIndex = 2;
            this.labelSummaryParts.Text = "零件";
            // 
            // textBoxParts
            // 
            this.textBoxParts.Location = new System.Drawing.Point(140, 55);
            this.textBoxParts.Name = "textBoxParts";
            this.textBoxParts.ReadOnly = true;
            this.textBoxParts.Size = new System.Drawing.Size(160, 23);
            this.textBoxParts.TabIndex = 3;

            // 
            // labelSummaryTax
            // 
            this.labelSummaryTax.AutoSize = true;
            this.labelSummaryTax.Location = new System.Drawing.Point(10, 88);
            this.labelSummaryTax.Name = "labelSummaryTax";
            this.labelSummaryTax.Size = new System.Drawing.Size(40, 15);
            this.labelSummaryTax.TabIndex = 4;
            this.labelSummaryTax.Text = "稅金";
            // 
            // textBoxTax
            // 
            this.textBoxTax.Location = new System.Drawing.Point(140, 85);
            this.textBoxTax.Name = "textBoxTax";
            this.textBoxTax.ReadOnly = true;
            this.textBoxTax.Size = new System.Drawing.Size(160, 23);
            this.textBoxTax.TabIndex = 5;

            // 
            // labelSummaryTotal
            // 
            this.labelSummaryTotal.AutoSize = true;
            this.labelSummaryTotal.Location = new System.Drawing.Point(10, 118);
            this.labelSummaryTotal.Name = "labelSummaryTotal";
            this.labelSummaryTotal.Size = new System.Drawing.Size(40, 15);
            this.labelSummaryTotal.TabIndex = 6;
            this.labelSummaryTotal.Text = "總費用";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(140, 115);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(160, 23);
            this.textBoxTotal.TabIndex = 7;

            // 
            // Buttons: 計算總額, 清除, 離開
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(360, 240);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 30);
            this.buttonCalculate.TabIndex = 10;
            this.buttonCalculate.Text = "計算總額";
            this.buttonCalculate.UseVisualStyleBackColor = true;

            this.buttonClearShort.Location = new System.Drawing.Point(480, 240);
            this.buttonClearShort.Name = "buttonClearShort";
            this.buttonClearShort.Size = new System.Drawing.Size(80, 30);
            this.buttonClearShort.TabIndex = 11;
            this.buttonClearShort.Text = "清除";
            this.buttonClearShort.UseVisualStyleBackColor = true;

            this.buttonExit.Location = new System.Drawing.Point(580, 240);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(80, 30);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "離開";
            this.buttonExit.UseVisualStyleBackColor = true;

            // hide previous dataGridView and other controls not in this layout
            this.dataGridViewRecords.Visible = false;

            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 400);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClearShort);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBoxFeeSummary);
            this.Controls.Add(this.groupBoxPartsAndLabor);
            this.Controls.Add(this.groupBoxMisc);
            this.Controls.Add(this.groupBoxFlushes);
            this.Controls.Add(this.groupBoxOilLube);
            this.Name = "Form1";
            this.Text = "汽車維修服務";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
