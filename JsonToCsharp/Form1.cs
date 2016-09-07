using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CSharp;
using Xamasoft.JsonClassGenerator;
using Newtonsoft.Json;

namespace JsonToCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void run_btn_Click(object sender, EventArgs e)
        {

            if (JsonCsharpHelp.IsEmpty(this.namespace_text.Text))
            {
                MessageBox.Show(this, "需要自定义一个名称空间", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (JsonCsharpHelp.IsEmpty(this.class_text.Text))
            {
                MessageBox.Show(this, "需要自定义一个主类名", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (JsonCsharpHelp.IsEmpty(this.json_text.Text))
            {
                MessageBox.Show(this, "json空值", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var gen = JsonCsharpHelp.Prepare(this.json_text.Text, this.class_text.Text, this.namespace_text.Text);
            if (gen == null) return;
            try
            {
                gen.GenerateClasses();
				this.csharp_text.Text = readFile(gen,this.class_text.Text);
                MessageBox.Show("转换成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "转换失败，Error: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private string readFile(JsonClassGenerator gen,string classname) {
			string result = "";
			try {
				StreamReader sr = new StreamReader(gen.TargetFolder + "\\" + classname + ".cs", Encoding.Default);
				String line;
				while ( ( line = sr.ReadLine() ) != null ) {
					result+=line.ToString()+"\r\n";
				}
				this.path_text.Text = gen.TargetFolder + "\\" + classname + ".cs";
			}
			catch ( Exception e ) {
				MessageBox.Show(e.ToString());
			}
			return result;
		}

		private void open_btn_Click(object sender, EventArgs e) {
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "json/js文件|*.json|全部|*.*";
			if ( open.ShowDialog() == DialogResult.OK ) {
				StreamReader sr = new StreamReader(open.FileName, Encoding.UTF8);
				String line;
				while ( ( line = sr.ReadLine() ) != null ) {
					this.json_text.Text += line.ToString() + "\r\n";
				}
				this.path_text.Text = open.FileName;
			}
		}

		private void generate_btn_Click(object sender, EventArgs e) {
			try {
				CSharpCodeProvider provider = new CSharpCodeProvider(); 
				var param = new CompilerParameters();
				param.GenerateInMemory = true;
				param.GenerateExecutable = false;
				param.ReferencedAssemblies.Add("System.dll");
				string serverAppPath = System.Windows.Forms.Application.StartupPath;
				param.ReferencedAssemblies.Add(serverAppPath+"\\Newtonsoft.Json.dll");
				param.ReferencedAssemblies.Add("System.Core.dll ");
				//param.ReferencedAssemblies.Add("Newtonsoft.Json.dll");
				var str = appendJsonGen(this.csharp_text.Text, this.class_text.Text,this.namespace_text.Text);
				this.csharp_text.Text = str;
				var  temp = provider.CompileAssemblyFromSource(param,str);
				Assembly assembly = temp.CompiledAssembly;
				var instance = assembly.CreateInstance(this.namespace_text.Text+ ".jsonGenerator");
				var type = assembly.GetType(this.namespace_text.Text + ".jsonGenerator");
				var method = type.GetMethod("Generator");
				var result=method.Invoke(instance, new object [ ] { this.json_text.Text });
				this.json_text.Text = JsonConvert.SerializeObject(result);
			}
			catch ( Exception ex ) {
				MessageBox.Show(ex.Message);
			}
			dynamic a = 1;
		}
		private string appendJsonGen(string str,string classstr,string namestr) {
			str = str.Insert(0, "using "+ namestr + ";\r\n");
			if ( str.LastIndexOf("}") > 0 ) {
				str=str.Insert(str.LastIndexOf("}") - 1, @" public  class jsonGenerator{
																						public dynamic Generator(string json) {
																							try {
																								var obj = JsonConvert.DeserializeObject<List<" + classstr + @">>(json);
																								if ( obj == null ) {
																									return JsonConvert.DeserializeObject<" + classstr + @">(json);
																								}
																								return obj;
																							}
																							catch ( Exception ex ) {
																								return JsonConvert.DeserializeObject<" + classstr + @">(json);
																							}
																						}
																					}");
			}
			return str;
		}
	}
}
