using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace razorTest
{
    public partial class Form1 : Form
    {
        string dir = @"" + System.Windows.Forms.Application.StartupPath.Replace(@"\bin\Debug", "") + @"\public\views\";
        public Form1()
        {
            InitializeComponent();
        }

        private void import_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "模板文件|*.cshtml|所有文件|*.*";
                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.path_text.Text = open.FileName;
                    //读取文件内容
                    StreamReader sr = new StreamReader(open.FileName, System.Text.Encoding.UTF8);
                    this.temp_text.Text = sr.ReadToEnd().ToString();
                    sr.Close();
                    if (!File.Exists(dir + Path.GetFileName(open.FileName)))
                    {
                        File.Copy(open.FileName, dir + Path.GetFileName(open.FileName), false);
                    }
                    else
                    {
                        if (MessageBox.Show("已有文件，覆盖?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.Yes)
                        {
                            if (System.IO.File.GetAttributes(dir + Path.GetFileName(open.FileName)).ToString().IndexOf("ReadOnly") != -1)
                            {
                                File.SetAttributes(dir + Path.GetFileName(open.FileName), FileAttributes.Normal);
                            }
                            File.Copy(open.FileName, dir + Path.GetFileName(open.FileName), true);
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void create_temp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(this.path_text.Text))
                {
                    if (MessageBox.Show("文件地址找不到,新建?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.path_text.Text = this.path_text.Text.Substring(0, this.path_text.Text.LastIndexOf(@"\") + 1);
                        if (Help.IsPath(this.path_text.Text))
                        {
                            if (File.Exists(this.path_text.Text + "newFile.cshtml"))
                            {
                                int i = 0;
                                while (File.Exists(this.path_text.Text + "newFile" + i + ".cshtml"))
                                {
                                    i++;
                                }
                                this.path_text.Text = this.path_text.Text + "newFile" + i + ".cshtml";
                            }
                            else
                            {
                                this.path_text.Text = this.path_text.Text + "newFile.cshtml";
                            }
                        }
                        else
                        {
                            if (File.Exists(dir + "newFile.cshtml"))
                            {
                                int i = 0;
                                while (File.Exists(dir + "newFile" + i + ".cshtml"))
                                {
                                    i++;
                                }
                                this.path_text.Text = dir + "newFile" + i + ".cshtml";

                            }
                            else
                            {
                                this.path_text.Text = dir + "newFile.cshtml";
                            }

                        }
                       
                    }
                    WriteFile();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void WriteFile()
        {
            FileStream FileStream = null;
            try
            {
                FileStream = new FileStream(this.path_text.Text, FileMode.OpenOrCreate, FileAccess.Write);

                using (StreamWriter str = new StreamWriter(FileStream, System.Text.Encoding.UTF8))//UTF8为编码
                {
                    str.Write(this.temp_text.Text);
                }
            }
            catch
            {

            }
            finally
            {
                FileStream.Close();
            }

            //在将文本写入文件前，处理文本行
            //StreamWriter一个参数默认覆盖
            //StreamWriter第二个参数为false覆盖现有文件，为true则把文本追加到文件末尾
            //using (System.IO.StreamWriter file = new System.IO.StreamWriter(this.path_text.Text))
            //{
            //    file.Write(this.temp_text.Text);//直接追加文件末尾，不换行
            //}
        }

        private void clear1_btn_Click(object sender, EventArgs e)
        {
            this.path_text.Text = string.Empty;
        }

        private void clear2_btn_Click(object sender, EventArgs e)
        {
            this.temp_text.Text = string.Empty;
        }

        private void clear3_btn_Click(object sender, EventArgs e)
        {
            this.result_text.Text = string.Empty;
        }

        private void run_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.temp_text.Text)) return;
            this.result_text.Text = RazorEngine.Razor.Parse(this.temp_text.Text);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {

        }

        private void formartCode_btn_Click(object sender, EventArgs e)
        {

        }



     
    }
}
