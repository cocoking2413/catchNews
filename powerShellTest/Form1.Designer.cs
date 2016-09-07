namespace powerShellTest
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.run_btn = new System.Windows.Forms.Button();
            this.command_text = new System.Windows.Forms.RichTextBox();
            this.return_text = new System.Windows.Forms.RichTextBox();
            this.clearCom_btn = new System.Windows.Forms.Button();
            this.clearReturn_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // run_btn
            // 
            this.run_btn.Location = new System.Drawing.Point(32, 155);
            this.run_btn.Name = "run_btn";
            this.run_btn.Size = new System.Drawing.Size(75, 23);
            this.run_btn.TabIndex = 0;
            this.run_btn.Text = "运行";
            this.run_btn.UseVisualStyleBackColor = true;
            this.run_btn.Click += new System.EventHandler(this.run_btn_Click);
            // 
            // command_text
            // 
            this.command_text.Location = new System.Drawing.Point(32, 24);
            this.command_text.Name = "command_text";
            this.command_text.Size = new System.Drawing.Size(1065, 105);
            this.command_text.TabIndex = 1;
            this.command_text.Text = "";
            // 
            // return_text
            // 
            this.return_text.Location = new System.Drawing.Point(32, 209);
            this.return_text.Name = "return_text";
            this.return_text.Size = new System.Drawing.Size(1065, 377);
            this.return_text.TabIndex = 2;
            this.return_text.Text = "";
            // 
            // clearCom_btn
            // 
            this.clearCom_btn.Location = new System.Drawing.Point(150, 155);
            this.clearCom_btn.Name = "clearCom_btn";
            this.clearCom_btn.Size = new System.Drawing.Size(75, 23);
            this.clearCom_btn.TabIndex = 3;
            this.clearCom_btn.Text = "清空（上）";
            this.clearCom_btn.UseVisualStyleBackColor = true;
            this.clearCom_btn.Click += new System.EventHandler(this.clearCom_btn_Click);
            // 
            // clearReturn_btn
            // 
            this.clearReturn_btn.Location = new System.Drawing.Point(269, 155);
            this.clearReturn_btn.Name = "clearReturn_btn";
            this.clearReturn_btn.Size = new System.Drawing.Size(75, 23);
            this.clearReturn_btn.TabIndex = 4;
            this.clearReturn_btn.Text = "清空（下）";
            this.clearReturn_btn.UseVisualStyleBackColor = true;
            this.clearReturn_btn.Click += new System.EventHandler(this.clearReturn_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 598);
            this.Controls.Add(this.clearReturn_btn);
            this.Controls.Add(this.clearCom_btn);
            this.Controls.Add(this.return_text);
            this.Controls.Add(this.command_text);
            this.Controls.Add(this.run_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button run_btn;
        private System.Windows.Forms.RichTextBox command_text;
        private System.Windows.Forms.RichTextBox return_text;
        private System.Windows.Forms.Button clearCom_btn;
        private System.Windows.Forms.Button clearReturn_btn;
    }
}

