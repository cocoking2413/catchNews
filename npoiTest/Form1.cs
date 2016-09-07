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
using Newtonsoft.Json;

namespace npoiTest {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void open_btn_Click(object sender, EventArgs e) {
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "excel文件|*.xls*|全部|*.*";
			if ( open.ShowDialog() == DialogResult.OK ) {
				var dt=NPOIHelper.ImportExceltoDt(open.FileName);
				this.view_text.Text = ConvertJsonString(dt);
			}
		}

		private void import_btn_Click(object sender, EventArgs e) {
			SaveFileDialog saveFile = new SaveFileDialog();
			saveFile.Filter = "excel文件|*.xls*| 其他文件(*.*)|*.*";  //设置对话框保存的文件类型 
			saveFile.RestoreDirectory = true;  //设置保存对话框是否记忆上次打开的目录
			if ( saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK ) {
				string localFilePath = saveFile.FileName;
				DataTable dt = new DataTable();
				dt=JsonConvert.DeserializeObject<DataTable>( this.view_text.Text.Trim() );
				NPOIHelper.ExportDTtoExcel(dt, "npoitest", localFilePath);
				MessageBox.Show("保存文件并写入内容成功。");
			}
		}
		private static string ConvertJsonString(string json) {
			//格式化json字符串
			JsonSerializer serializer = new JsonSerializer();
			TextReader tr = new StringReader(json);
			JsonTextReader jtr = new JsonTextReader(tr);
			object obj = serializer.Deserialize(jtr);
			if ( obj != null ) {
				StringWriter textWriter = new StringWriter();
				JsonTextWriter jsonWriter = new JsonTextWriter(textWriter) {
					Formatting = Formatting.Indented,
					Indentation = 4,
					IndentChar = ' '
				};
				serializer.Serialize(jsonWriter, obj);
				return textWriter.ToString();
			}
			else {
				return json;
			}
		}
		private static string ConvertJsonString(Object obj) {
			//格式化json字符串
			JsonSerializer serializer = new JsonSerializer();
			if ( obj != null ) {
				StringWriter textWriter = new StringWriter();
				JsonTextWriter jsonWriter = new JsonTextWriter(textWriter) {
					Formatting = Formatting.Indented,
					Indentation = 4,
					IndentChar = ' '
				};
				serializer.Serialize(jsonWriter, obj);
				return textWriter.ToString();
			}
			else {
				return "";
			}
		}
	}
}
