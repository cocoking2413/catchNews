namespace npoiTest {
	partial class Form2 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if ( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.result_text = new System.Windows.Forms.RichTextBox();
			this.select_text = new System.Windows.Forms.RichTextBox();
			this.run_btn = new System.Windows.Forms.Button();
			this.open_btn = new System.Windows.Forms.Button();
			this.path_text = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// result_text
			// 
			this.result_text.Location = new System.Drawing.Point(13, 322);
			this.result_text.Name = "result_text";
			this.result_text.Size = new System.Drawing.Size(858, 243);
			this.result_text.TabIndex = 0;
			this.result_text.Text = "";
			// 
			// select_text
			// 
			this.select_text.Location = new System.Drawing.Point(12, 84);
			this.select_text.Name = "select_text";
			this.select_text.Size = new System.Drawing.Size(858, 184);
			this.select_text.TabIndex = 1;
			this.select_text.Text = "";
			// 
			// run_btn
			// 
			this.run_btn.Location = new System.Drawing.Point(13, 284);
			this.run_btn.Name = "run_btn";
			this.run_btn.Size = new System.Drawing.Size(75, 23);
			this.run_btn.TabIndex = 2;
			this.run_btn.Text = "执行";
			this.run_btn.UseVisualStyleBackColor = true;
			this.run_btn.Click += new System.EventHandler(this.run_btn_Click);
			// 
			// open_btn
			// 
			this.open_btn.Location = new System.Drawing.Point(13, 38);
			this.open_btn.Name = "open_btn";
			this.open_btn.Size = new System.Drawing.Size(75, 23);
			this.open_btn.TabIndex = 3;
			this.open_btn.Text = "选择文件";
			this.open_btn.UseVisualStyleBackColor = true;
			this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
			// 
			// path_text
			// 
			this.path_text.Location = new System.Drawing.Point(108, 38);
			this.path_text.Name = "path_text";
			this.path_text.Size = new System.Drawing.Size(762, 21);
			this.path_text.TabIndex = 4;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(883, 579);
			this.Controls.Add(this.path_text);
			this.Controls.Add(this.open_btn);
			this.Controls.Add(this.run_btn);
			this.Controls.Add(this.select_text);
			this.Controls.Add(this.result_text);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox result_text;
		private System.Windows.Forms.RichTextBox select_text;
		private System.Windows.Forms.Button run_btn;
		private System.Windows.Forms.Button open_btn;
		private System.Windows.Forms.TextBox path_text;
	}
}