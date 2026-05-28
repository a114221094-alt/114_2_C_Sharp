namespace mutiformvariable
{
    public partial class SecondForm1 : Form
    {
        public SecondForm1()
        {
            InitializeComponent();
        }

        private void SecondForm1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 這個方法通常由設計工具自動產生，用於初始化表單元件。
        /// 如果缺少，請新增此方法以解決 CS0103 錯誤。
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SecondForm1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "SecondForm1";
            this.Load += new System.EventHandler(this.SecondForm1_Load);
            this.ResumeLayout(false);
        }
    }
}
