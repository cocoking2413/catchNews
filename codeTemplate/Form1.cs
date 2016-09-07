using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
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
using System.Data.OleDb;//access
using System.Data.SqlClient;  //sql
using MySql.Data.MySqlClient;
using System.Diagnostics;
using DotLiquid; //MySQL 
namespace codeTemplate
{
    public partial class Form1 : Form
    {
        public Dictionary<int, string> dataTypeList = new Dictionary<int, string>();
        public List<dbList> dbs = new List<dbList>();
        public Form1()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            dataTypeList.Add(0, "打开文件");
            dataTypeList.Add(1, "sql数据库");
            dataTypeList.Add(2, "json数据");

            this.typeComb.DataSource = dataTypeList.ToList();
            this.typeComb.ValueMember = "key";
            this.typeComb.DisplayMember = "value";

            dbs.Add(new dbList() { ID = 0, Name = "Access", connectStr = @"Provider=Microsoft.Jet.OleDb.4.0;Data Source=C:BegASPNETNorthwind.mdb" });
            dbs.Add(new dbList() { ID = 1, Name = "Sql", connectStr = @"Database=zms3.02;Server=192.168.1.254;uid=sa;pwd=123;" });
            dbs.Add(new dbList() { ID = 2, Name = "MySQL ", connectStr = @"Database=test;Data Source=127.0.0.1;User Id=root;Password=root;pooling=false;CharSet=utf8;port=3306" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con_file_path = this.dataText.Text;
            //读取json文件  
            using (StreamReader sr = new StreamReader(con_file_path, Encoding.UTF8))
            {
                try
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Converters.Add(new JavaScriptDateTimeConverter());
                    serializer.NullValueHandling = NullValueHandling.Ignore;

                    //构建Json.net的读取流  
                    JsonReader reader = new JsonTextReader(sr);
                    //对读取出的Json.net的reader流进行反序列化，并装载到模型中  
                    var list = serializer.Deserialize<dynamic>(reader);
                    if (string.IsNullOrWhiteSpace(this.tempview.Text)) return;
                    this.viewlist.Text = RazorEngine.Razor.Parse(this.tempview.Text,list);//Razor Render
                    //this.viewlist.Text = Template.Parse(this.tempview.Text).Render(Hash.FromAnonymousObject(new { })); //DotLiquid Render
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void typeComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.typeComb.SelectedIndex)
            {
                case 0:
                    OpenFileDialog openFile = new OpenFileDialog();
                    openFile.Filter = "json文件(*.json)|*.json| 文档(*.txt)|*txt|c#文件(*.cs)|*.cs | 其他文件(*.*)|*.*";  //设置对话框保存的文件类型 
                    openFile.RestoreDirectory = true;  //设置保存对话框是否记忆上次打开的目录
                    if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        this.dataText.Text = openFile.FileName;

                    }
                    break;
                case 1:
                    this.dboList.DataSource = dbs;
                    this.dboList.ValueMember = "ID";
                    this.dboList.DisplayMember = "Name";
                    break;
                case 2:
                    break;
                default:
                    break;
            }
            if (this.typeComb.SelectedIndex != 1) {
                this.dboList.DataSource = null;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "文档(*.txt)|*txt| json文件(*.json)|*.js*| html文件(*.html)|*.html| c#文件(*.cs)|*.cs | 其他文件(*.*)|*.*";  //设置对话框保存的文件类型 
            saveFile.RestoreDirectory = true;  //设置保存对话框是否记忆上次打开的目录
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string localFilePath = saveFile.FileName;
                string file = this.viewlist.Text;
                StreamWriter sw = new StreamWriter(localFilePath, false, Encoding.UTF8);
                sw.Write(file);
                sw.Close();
                MessageBox.Show("保存文件并写入内容成功。");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.viewlist.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.dboList == null)
                {
                    //读取json文件  
                    using (StreamReader sr = new StreamReader(this.dataText.Text, Encoding.UTF8))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Converters.Add(new JavaScriptDateTimeConverter());
                        serializer.NullValueHandling = NullValueHandling.Ignore;

                        //构建Json.net的读取流  
                        JsonReader reader = new JsonTextReader(sr);
                        //对读取出的Json.net的reader流进行反序列化，并装载到模型中  
                        var list = serializer.Deserialize<object>(reader);
                        this.viewlist.Text = ConvertJsonString(JsonConvert.SerializeObject(list)); 
                    }
                }
                else if(!string.IsNullOrWhiteSpace(this.dataText.Text)) {
                    switch (this.dboList.SelectedIndex)
                    {
                        case 0://access
                            OleDbConnection accessConnection = new OleDbConnection(this.dataText.Text);
                            try
                            {
                                accessConnection.Open();
                                
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message); }
                            finally
                            {
                                accessConnection.Close();
                            }
                            break;
                        case 1://sql server
                            SqlConnection sqlConnection = new SqlConnection(this.dataText.Text);
                            try
                            {
                                sqlConnection.Open();
                                SqlCommand com = sqlConnection.CreateCommand();
                                com.CommandText = string.IsNullOrWhiteSpace(this.tempview.Text) ? "select name from sysobjects where xtype='u'" : this.tempview.Text;
                                SqlDataAdapter sqlReader = new SqlDataAdapter(com.CommandText, sqlConnection);
                                DataSet dataset1 = new System.Data.DataSet();
                                sqlReader.Fill(dataset1);
                                this.viewlist.Text =ConvertJsonString( JsonConvert.SerializeObject(dataset1)); 
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message); }
                            finally
                            {
                                sqlConnection.Close();
                            }
                            break;
                        case 2://mysql
                            MySqlConnection mysqlConnection = new MySqlConnection(this.dataText.Text);
                            try
                            {
                                mysqlConnection.Open();
                                
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message); }
                            finally
                            {
                                mysqlConnection.Close();
                            }
                            break;
                        default:
                            MessageBox.Show("。。。");
                            break;
                    }
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dboList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataText.Text = dbs.Find(p => p.ID == this.dboList.SelectedIndex).connectStr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                switch (this.dboList.SelectedIndex)
                {
                    case 0://access
                        OleDbConnection accessConnection = new OleDbConnection(this.dataText.Text);
                        try
                        {
                            accessConnection.Open();
                            MessageBox.Show("测试通过");
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                        finally
                        {
                            accessConnection.Close();
                        } 
                        break;
                    case 1://sql server
                        SqlConnection sqlConnection = new SqlConnection(this.dataText.Text);
                        try
                        {
                            sqlConnection.Open();
                            MessageBox.Show("测试通过");
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                        finally
                        {
                            sqlConnection.Close();
                        } 
                        break;
                    case 2://mysql
                        MySqlConnection mysqlConnection = new MySqlConnection(this.dataText.Text);
                        try
                        {
                            mysqlConnection.Open();
                            MessageBox.Show("测试通过");
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                        finally
                        {
                            mysqlConnection.Close();
                        } 
                        break;
                    default:
                        MessageBox.Show("。。。");
                        break;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private static string ConvertJsonString(string str)
        {
            //格式化json字符串
            JsonSerializer serializer = new JsonSerializer();
            TextReader tr = new StringReader(str);
            JsonTextReader jtr = new JsonTextReader(tr);
            object obj = serializer.Deserialize(jtr);
            if (obj != null)
            {
                StringWriter textWriter = new StringWriter();
                JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                {
                    Formatting = Formatting.Indented,
                    Indentation = 4,
                    IndentChar = ' '
                };
                serializer.Serialize(jsonWriter, obj);
                return textWriter.ToString();
            }
            else
            {
                return str;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //找到服务器物理路径  
            string serverAppPath = System.Windows.Forms.Application.StartupPath;
            //string serverAppPath = @"d:\";
            //构成配置文件路径  
            string con_file_path = @"" + serverAppPath + @"\lib";
            Process p = new Process();
            p.StartInfo.WorkingDirectory = con_file_path;
            p.StartInfo.FileName = "JsonCSharpClassGenerator.exe";
            p.Start();

        }
    }
}
