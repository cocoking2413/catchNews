namespace codeTemplate
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
            this.preview = new System.Windows.Forms.Button();
            this.viewlist = new System.Windows.Forms.RichTextBox();
            this.tempview = new System.Windows.Forms.RichTextBox();
            this.label = new System.Windows.Forms.Label();
            this.dataText = new System.Windows.Forms.TextBox();
            this.typeComb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.save = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dboList = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // preview
            // 
            this.preview.Location = new System.Drawing.Point(578, 537);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(75, 23);
            this.preview.TabIndex = 0;
            this.preview.Text = "渲染预览";
            this.preview.UseVisualStyleBackColor = true;
            this.preview.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewlist
            // 
            this.viewlist.Location = new System.Drawing.Point(811, 66);
            this.viewlist.Name = "viewlist";
            this.viewlist.Size = new System.Drawing.Size(490, 506);
            this.viewlist.TabIndex = 1;
            this.viewlist.Text = "";
            // 
            // tempview
            // 
            this.tempview.Location = new System.Drawing.Point(13, 66);
            this.tempview.Name = "tempview";
            this.tempview.Size = new System.Drawing.Size(512, 506);
            this.tempview.TabIndex = 2;
            this.tempview.Text = "";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 26);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(41, 12);
            this.label.TabIndex = 3;
            this.label.Text = "数据源";
            // 
            // dataText
            // 
            this.dataText.Location = new System.Drawing.Point(60, 16);
            this.dataText.Name = "dataText";
            this.dataText.Size = new System.Drawing.Size(465, 21);
            this.dataText.TabIndex = 4;
            // 
            // typeComb
            // 
            this.typeComb.FormattingEnabled = true;
            this.typeComb.Location = new System.Drawing.Point(532, 16);
            this.typeComb.Name = "typeComb";
            this.typeComb.Size = new System.Drawing.Size(121, 20);
            this.typeComb.TabIndex = 5;
            this.typeComb.SelectedIndexChanged += new System.EventHandler(this.typeComb_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(545, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 401);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "字段声明";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(689, 490);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 7;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(689, 537);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 8;
            this.clear.Text = "清空";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "数据预览";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dboList
            // 
            this.dboList.FormattingEnabled = true;
            this.dboList.Location = new System.Drawing.Point(673, 18);
            this.dboList.Name = "dboList";
            this.dboList.Size = new System.Drawing.Size(121, 20);
            this.dboList.TabIndex = 10;
            this.dboList.SelectedIndexChanged += new System.EventHandler(this.dboList_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(811, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "连接测试";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(903, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "生成c#类工具";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 584);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dboList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.typeComb);
            this.Controls.Add(this.dataText);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tempview);
            this.Controls.Add(this.viewlist);
            this.Controls.Add(this.preview);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button preview;
        private System.Windows.Forms.RichTextBox viewlist;
        private System.Windows.Forms.RichTextBox tempview;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox dataText;
        private System.Windows.Forms.ComboBox typeComb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox dboList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

