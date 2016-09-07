namespace razorTest
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
            this.create_temp_btn = new System.Windows.Forms.Button();
            this.import_btn = new System.Windows.Forms.Button();
            this.temp_text = new System.Windows.Forms.RichTextBox();
            this.result_text = new System.Windows.Forms.RichTextBox();
            this.path_text = new System.Windows.Forms.TextBox();
            this.run_btn = new System.Windows.Forms.Button();
            this.clear1_btn = new System.Windows.Forms.Button();
            this.clear2_btn = new System.Windows.Forms.Button();
            this.clear3_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.formartCode_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // create_temp_btn
            // 
            this.create_temp_btn.Location = new System.Drawing.Point(25, 26);
            this.create_temp_btn.Name = "create_temp_btn";
            this.create_temp_btn.Size = new System.Drawing.Size(87, 23);
            this.create_temp_btn.TabIndex = 0;
            this.create_temp_btn.Text = "保存模板";
            this.create_temp_btn.UseVisualStyleBackColor = true;
            this.create_temp_btn.Click += new System.EventHandler(this.create_temp_btn_Click);
            // 
            // import_btn
            // 
            this.import_btn.Location = new System.Drawing.Point(118, 26);
            this.import_btn.Name = "import_btn";
            this.import_btn.Size = new System.Drawing.Size(75, 23);
            this.import_btn.TabIndex = 1;
            this.import_btn.Text = "导入模板";
            this.import_btn.UseVisualStyleBackColor = true;
            this.import_btn.Click += new System.EventHandler(this.import_btn_Click);
            // 
            // temp_text
            // 
            this.temp_text.Location = new System.Drawing.Point(25, 56);
            this.temp_text.Name = "temp_text";
            this.temp_text.Size = new System.Drawing.Size(592, 592);
            this.temp_text.TabIndex = 2;
            this.temp_text.Text = "";
            // 
            // result_text
            // 
            this.result_text.Location = new System.Drawing.Point(729, 56);
            this.result_text.Name = "result_text";
            this.result_text.Size = new System.Drawing.Size(510, 592);
            this.result_text.TabIndex = 3;
            this.result_text.Text = "";
            // 
            // path_text
            // 
            this.path_text.Location = new System.Drawing.Point(212, 26);
            this.path_text.Name = "path_text";
            this.path_text.Size = new System.Drawing.Size(405, 21);
            this.path_text.TabIndex = 4;
            // 
            // run_btn
            // 
            this.run_btn.Location = new System.Drawing.Point(633, 56);
            this.run_btn.Name = "run_btn";
            this.run_btn.Size = new System.Drawing.Size(75, 23);
            this.run_btn.TabIndex = 5;
            this.run_btn.Text = "生成";
            this.run_btn.UseVisualStyleBackColor = true;
            this.run_btn.Click += new System.EventHandler(this.run_btn_Click);
            // 
            // clear1_btn
            // 
            this.clear1_btn.Location = new System.Drawing.Point(633, 111);
            this.clear1_btn.Name = "clear1_btn";
            this.clear1_btn.Size = new System.Drawing.Size(75, 23);
            this.clear1_btn.TabIndex = 6;
            this.clear1_btn.Text = "清空 ^";
            this.clear1_btn.UseVisualStyleBackColor = true;
            this.clear1_btn.Click += new System.EventHandler(this.clear1_btn_Click);
            // 
            // clear2_btn
            // 
            this.clear2_btn.Location = new System.Drawing.Point(633, 163);
            this.clear2_btn.Name = "clear2_btn";
            this.clear2_btn.Size = new System.Drawing.Size(75, 23);
            this.clear2_btn.TabIndex = 7;
            this.clear2_btn.Text = "《 清空";
            this.clear2_btn.UseVisualStyleBackColor = true;
            this.clear2_btn.Click += new System.EventHandler(this.clear2_btn_Click);
            // 
            // clear3_btn
            // 
            this.clear3_btn.Location = new System.Drawing.Point(633, 219);
            this.clear3_btn.Name = "clear3_btn";
            this.clear3_btn.Size = new System.Drawing.Size(75, 23);
            this.clear3_btn.TabIndex = 8;
            this.clear3_btn.Text = "清空 》";
            this.clear3_btn.UseVisualStyleBackColor = true;
            this.clear3_btn.Click += new System.EventHandler(this.clear3_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(633, 276);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 9;
            this.save_btn.Text = "保存";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // formartCode_btn
            // 
            this.formartCode_btn.Location = new System.Drawing.Point(633, 329);
            this.formartCode_btn.Name = "formartCode_btn";
            this.formartCode_btn.Size = new System.Drawing.Size(75, 23);
            this.formartCode_btn.TabIndex = 10;
            this.formartCode_btn.Text = "格式化代码";
            this.formartCode_btn.UseVisualStyleBackColor = true;
            this.formartCode_btn.Click += new System.EventHandler(this.formartCode_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 660);
            this.Controls.Add(this.formartCode_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.clear3_btn);
            this.Controls.Add(this.clear2_btn);
            this.Controls.Add(this.clear1_btn);
            this.Controls.Add(this.run_btn);
            this.Controls.Add(this.path_text);
            this.Controls.Add(this.result_text);
            this.Controls.Add(this.temp_text);
            this.Controls.Add(this.import_btn);
            this.Controls.Add(this.create_temp_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_temp_btn;
        private System.Windows.Forms.Button import_btn;
        private System.Windows.Forms.RichTextBox temp_text;
        private System.Windows.Forms.RichTextBox result_text;
        private System.Windows.Forms.TextBox path_text;
        private System.Windows.Forms.Button run_btn;
        private System.Windows.Forms.Button clear1_btn;
        private System.Windows.Forms.Button clear2_btn;
        private System.Windows.Forms.Button clear3_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button formartCode_btn;
    }
}

