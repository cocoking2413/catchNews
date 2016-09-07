namespace acceptMsg
{
    partial class FindWindow
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
            this.accept_text = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // accept_text
            // 
            this.accept_text.Location = new System.Drawing.Point(472, 24);
            this.accept_text.Name = "accept_text";
            this.accept_text.Size = new System.Drawing.Size(498, 546);
            this.accept_text.TabIndex = 0;
            this.accept_text.Text = "";
            // 
            // FindWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 582);
            this.Controls.Add(this.accept_text);
            this.Name = "FindWindow";
            this.Text = "FindWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox accept_text;
    }
}

