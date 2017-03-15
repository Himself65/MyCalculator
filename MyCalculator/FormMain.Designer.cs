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
            this.inPut1 = new System.Windows.Forms.TextBox();
            this.inPut2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.outPut1 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Max = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inPut1
            // 
            this.inPut1.Location = new System.Drawing.Point(13, 13);
            this.inPut1.Name = "inPut1";
            this.inPut1.Size = new System.Drawing.Size(80, 21);
            this.inPut1.TabIndex = 0;
            this.inPut1.TextChanged += new System.EventHandler(this.inPut1_TextChanged);
            // 
            // inPut2
            // 
            this.inPut2.Location = new System.Drawing.Point(99, 13);
            this.inPut2.Name = "inPut2";
            this.inPut2.Size = new System.Drawing.Size(80, 21);
            this.inPut2.TabIndex = 1;
            this.inPut2.TextChanged += new System.EventHandler(this.inPut2_TextChanged);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(196, 16);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(47, 12);
            this.result.TabIndex = 2;
            this.result.Text = "result:";
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // outPut1
            // 
            this.outPut1.Location = new System.Drawing.Point(238, 13);
            this.outPut1.Name = "outPut1";
            this.outPut1.Size = new System.Drawing.Size(64, 21);
            this.outPut1.TabIndex = 6;
            this.outPut1.TextChanged += new System.EventHandler(this.outPut1_TextChanged);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(13, 61);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Sub
            // 
            this.Sub.Location = new System.Drawing.Point(99, 60);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(75, 23);
            this.Sub.TabIndex = 3;
            this.Sub.Text = "Sub";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Max
            // 
            this.Max.BackColor = System.Drawing.SystemColors.Control;
            this.Max.Cursor = System.Windows.Forms.Cursors.Default;
            this.Max.Location = new System.Drawing.Point(13, 91);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(75, 23);
            this.Max.TabIndex = 4;
            this.Max.Text = "Max";
            this.Max.UseVisualStyleBackColor = false;
            this.Max.Click += new System.EventHandler(this.Max_Click_1);
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(99, 91);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(75, 23);
            this.Min.TabIndex = 5;
            this.Min.Text = "Min";
            this.Min.UseVisualStyleBackColor = true;
            this.Min.Click += new System.EventHandler(this.Min_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(225, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "by Himself65";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 129);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.outPut1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.inPut2);
            this.Controls.Add(this.inPut1);
            this.Name = "FormMain";
            this.Text = "计算器";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox inPut1;
        private System.Windows.Forms.TextBox inPut2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox outPut1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Max;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Label label1;
    }
}
#endregion