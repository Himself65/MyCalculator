namespace MyCalculator
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
			this.InPutBox = new System.Windows.Forms.TextBox();
			this.OutPutBox = new System.Windows.Forms.TextBox();
			this.FixBotton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// InPutBox
			// 
			this.InPutBox.Location = new System.Drawing.Point(24, 12);
			this.InPutBox.Name = "InPutBox";
			this.InPutBox.Size = new System.Drawing.Size(227, 21);
			this.InPutBox.TabIndex = 0;
			this.InPutBox.TextChanged += new System.EventHandler(this.InPutBox_TextChanged);
			// 
			// OutPutBox
			// 
			this.OutPutBox.Location = new System.Drawing.Point(24, 50);
			this.OutPutBox.Name = "OutPutBox";
			this.OutPutBox.Size = new System.Drawing.Size(227, 21);
			this.OutPutBox.TabIndex = 1;
			this.OutPutBox.TextChanged += new System.EventHandler(this.OutPutBox_TextChanged);
			// 
			// FixBotton
			// 
			this.FixBotton.Location = new System.Drawing.Point(24, 94);
			this.FixBotton.Name = "FixBotton";
			this.FixBotton.Size = new System.Drawing.Size(75, 23);
			this.FixBotton.TabIndex = 2;
			this.FixBotton.Text = "Fix";
			this.FixBotton.UseVisualStyleBackColor = true;
			this.FixBotton.Click += new System.EventHandler(this.FixBotton_Click);
			// 
			// FormMain
			// 
			this.ClientSize = new System.Drawing.Size(302, 166);
			this.Controls.Add(this.FixBotton);
			this.Controls.Add(this.OutPutBox);
			this.Controls.Add(this.InPutBox);
			this.Name = "FormMain";
			this.Load += new System.EventHandler(this.FormMain_Load_1);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        private System.Windows.Forms.TextBox InPutBox;
        private System.Windows.Forms.TextBox OutPutBox;
        private System.Windows.Forms.Button FixBotton;
    }
}
#endregion