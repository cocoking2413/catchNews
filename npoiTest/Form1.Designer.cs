namespace npoiTest {
	partial class Form1 {
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing) {
			if ( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent() {
			this.open_btn = new System.Windows.Forms.Button();
			this.import_btn = new System.Windows.Forms.Button();
			this.view_text = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// open_btn
			// 
			this.open_btn.Location = new System.Drawing.Point(756, 123);
			this.open_btn.Name = "open_btn";
			this.open_btn.Size = new System.Drawing.Size(75, 23);
			this.open_btn.TabIndex = 0;
			this.open_btn.Text = "打开";
			this.open_btn.UseVisualStyleBackColor = true;
			this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
			// 
			// import_btn
			// 
			this.import_btn.Location = new System.Drawing.Point(756, 229);
			this.import_btn.Name = "import_btn";
			this.import_btn.Size = new System.Drawing.Size(75, 23);
			this.import_btn.TabIndex = 1;
			this.import_btn.Text = "导出";
			this.import_btn.UseVisualStyleBackColor = true;
			this.import_btn.Click += new System.EventHandler(this.import_btn_Click);
			// 
			// view_text
			// 
			this.view_text.Location = new System.Drawing.Point(12, 12);
			this.view_text.Name = "view_text";
			this.view_text.Size = new System.Drawing.Size(722, 447);
			this.view_text.TabIndex = 2;
			this.view_text.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(861, 471);
			this.Controls.Add(this.view_text);
			this.Controls.Add(this.import_btn);
			this.Controls.Add(this.open_btn);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button open_btn;
		private System.Windows.Forms.Button import_btn;
		private System.Windows.Forms.RichTextBox view_text;
	}
}

