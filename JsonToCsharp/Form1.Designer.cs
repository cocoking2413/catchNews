namespace JsonToCsharp
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
			this.json_text = new System.Windows.Forms.RichTextBox();
			this.csharp_text = new System.Windows.Forms.RichTextBox();
			this.run_btn = new System.Windows.Forms.Button();
			this.namespace_text = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.class_text = new System.Windows.Forms.TextBox();
			this.open_btn = new System.Windows.Forms.Button();
			this.generate_btn = new System.Windows.Forms.Button();
			this.path_text = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// json_text
			// 
			this.json_text.Location = new System.Drawing.Point(13, 92);
			this.json_text.Name = "json_text";
			this.json_text.Size = new System.Drawing.Size(417, 502);
			this.json_text.TabIndex = 0;
			this.json_text.Text = "";
			// 
			// csharp_text
			// 
			this.csharp_text.Location = new System.Drawing.Point(611, 92);
			this.csharp_text.Name = "csharp_text";
			this.csharp_text.Size = new System.Drawing.Size(388, 502);
			this.csharp_text.TabIndex = 1;
			this.csharp_text.Text = "";
			// 
			// run_btn
			// 
			this.run_btn.Location = new System.Drawing.Point(438, 244);
			this.run_btn.Name = "run_btn";
			this.run_btn.Size = new System.Drawing.Size(75, 23);
			this.run_btn.TabIndex = 2;
			this.run_btn.Text = "run";
			this.run_btn.UseVisualStyleBackColor = true;
			this.run_btn.Click += new System.EventHandler(this.run_btn_Click);
			// 
			// namespace_text
			// 
			this.namespace_text.Location = new System.Drawing.Point(436, 131);
			this.namespace_text.Name = "namespace_text";
			this.namespace_text.Size = new System.Drawing.Size(169, 21);
			this.namespace_text.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(436, 100);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "名称空间";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(435, 173);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 6;
			this.label2.Text = "主类名";
			// 
			// class_text
			// 
			this.class_text.Location = new System.Drawing.Point(435, 204);
			this.class_text.Name = "class_text";
			this.class_text.Size = new System.Drawing.Size(169, 21);
			this.class_text.TabIndex = 5;
			// 
			// open_btn
			// 
			this.open_btn.Location = new System.Drawing.Point(438, 294);
			this.open_btn.Name = "open_btn";
			this.open_btn.Size = new System.Drawing.Size(75, 23);
			this.open_btn.TabIndex = 7;
			this.open_btn.Text = "open";
			this.open_btn.UseVisualStyleBackColor = true;
			this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
			// 
			// generate_btn
			// 
			this.generate_btn.Location = new System.Drawing.Point(438, 343);
			this.generate_btn.Name = "generate_btn";
			this.generate_btn.Size = new System.Drawing.Size(75, 23);
			this.generate_btn.TabIndex = 8;
			this.generate_btn.Text = "generate";
			this.generate_btn.UseVisualStyleBackColor = true;
			this.generate_btn.Click += new System.EventHandler(this.generate_btn_Click);
			// 
			// path_text
			// 
			this.path_text.Location = new System.Drawing.Point(13, 43);
			this.path_text.Name = "path_text";
			this.path_text.Size = new System.Drawing.Size(986, 21);
			this.path_text.TabIndex = 9;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1039, 609);
			this.Controls.Add(this.path_text);
			this.Controls.Add(this.generate_btn);
			this.Controls.Add(this.open_btn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.class_text);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.namespace_text);
			this.Controls.Add(this.run_btn);
			this.Controls.Add(this.csharp_text);
			this.Controls.Add(this.json_text);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox json_text;
        private System.Windows.Forms.RichTextBox csharp_text;
        private System.Windows.Forms.Button run_btn;
        private System.Windows.Forms.TextBox namespace_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox class_text;
		private System.Windows.Forms.Button open_btn;
		private System.Windows.Forms.Button generate_btn;
		private System.Windows.Forms.TextBox path_text;
	}
}

