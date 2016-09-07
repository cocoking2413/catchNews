namespace catchNews
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
            this.start = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.keyword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.viewList = new System.Windows.Forms.RichTextBox();
            this.channelDrop = new System.Windows.Forms.ComboBox();
            this.url = new System.Windows.Forms.ComboBox();
            this.Num = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Num)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(799, 19);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 0;
            this.start.Text = "开始获取";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(917, 19);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 1;
            this.clear.Text = "清空列表";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // keyword
            // 
            this.keyword.Location = new System.Drawing.Point(301, 21);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(251, 21);
            this.keyword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "关键字";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "条数";
            // 
            // viewList
            // 
            this.viewList.Location = new System.Drawing.Point(23, 101);
            this.viewList.Name = "viewList";
            this.viewList.Size = new System.Drawing.Size(1215, 493);
            this.viewList.TabIndex = 6;
            this.viewList.Text = "";
            // 
            // channelDrop
            // 
            this.channelDrop.FormattingEnabled = true;
            this.channelDrop.Location = new System.Drawing.Point(572, 66);
            this.channelDrop.Name = "channelDrop";
            this.channelDrop.Size = new System.Drawing.Size(189, 20);
            this.channelDrop.TabIndex = 7;
            // 
            // url
            // 
            this.url.FormattingEnabled = true;
            this.url.Location = new System.Drawing.Point(32, 22);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(216, 20);
            this.url.TabIndex = 8;
            this.url.SelectedIndexChanged += new System.EventHandler(this.url_SelectedIndexChanged);
            // 
            // Num
            // 
            this.Num.Location = new System.Drawing.Point(301, 65);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(251, 21);
            this.Num.TabIndex = 9;
            this.Num.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1094, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.url);
            this.Controls.Add(this.channelDrop);
            this.Controls.Add(this.viewList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keyword);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox keyword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox viewList;
		private System.Windows.Forms.ComboBox channelDrop;
		private System.Windows.Forms.ComboBox url;
        private System.Windows.Forms.NumericUpDown Num;
        private System.Windows.Forms.Button button1;
	}
}

