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
using DCommon.LinqToNPOI;
using LinqToExcel;
using Newtonsoft.Json;

namespace npoiTest {
	public partial class Form2 : Form {
		public Form2() {
			InitializeComponent();
		}
		public static string fileName = "";
		private void open_btn_Click(object sender, EventArgs e) {
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "excel文件|*.xls*|全部文件|*.*";
			if ( open.ShowDialog() == DialogResult.OK ) {
				fileName = open.FileName;
			}
			this.path_text.Text = fileName;
		}

		private void run_btn_Click(object sender, EventArgs e) {
			//var excel = new ExcelQueryFactory(fileName);
			//var tsheet = excel.Worksheet(0);

			//var query = from p in tsheet
			//			where p ["Age"].Cast<int>() > 30
			//			select p;

			var dt=NPOIHelper.ImportExceltoDt(fileName,0,0);

			var query = from q in dt.AsEnumerable()
						where int.Parse(q.Field<string>("Age")) < 30
						select q.ItemArray;

			this.result_text.Text = ConvertJsonString(query);
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
				return "null";
			}
		}
	}
}
