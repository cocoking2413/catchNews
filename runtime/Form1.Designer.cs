namespace runtime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.code_text = new System.Windows.Forms.RichTextBox();
            this.run_btn = new System.Windows.Forms.Button();
            this.class_text = new System.Windows.Forms.TextBox();
            this.main_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // code_text
            // 
            this.code_text.Location = new System.Drawing.Point(12, 22);
            this.code_text.Name = "code_text";
            this.code_text.Size = new System.Drawing.Size(606, 571);
            this.code_text.TabIndex = 0;
            this.code_text.Text = resources.GetString("code_text.Text");
            // 
            // run_btn
            // 
            this.run_btn.Location = new System.Drawing.Point(644, 164);
            this.run_btn.Name = "run_btn";
            this.run_btn.Size = new System.Drawing.Size(75, 23);
            this.run_btn.TabIndex = 1;
            this.run_btn.Text = "运行";
            this.run_btn.UseVisualStyleBackColor = true;
            this.run_btn.Click += new System.EventHandler(this.run_btn_Click);
            // 
            // class_text
            // 
            this.class_text.Location = new System.Drawing.Point(644, 55);
            this.class_text.Name = "class_text";
            this.class_text.Size = new System.Drawing.Size(281, 21);
            this.class_text.TabIndex = 2;
            this.class_text.Text = "First.Program";
            // 
            // main_text
            // 
            this.main_text.Location = new System.Drawing.Point(644, 111);
            this.main_text.Name = "main_text";
            this.main_text.Size = new System.Drawing.Size(281, 21);
            this.main_text.TabIndex = 3;
            this.main_text.Text = "Main";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(645, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "命名空间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "主函数";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "自定义函数";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 631);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.main_text);
            this.Controls.Add(this.class_text);
            this.Controls.Add(this.run_btn);
            this.Controls.Add(this.code_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox code_text;
        private System.Windows.Forms.Button run_btn;
        private System.Windows.Forms.TextBox class_text;
        private System.Windows.Forms.TextBox main_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

