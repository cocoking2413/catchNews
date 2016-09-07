using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace catchNews
{
    public partial class Form1 : Form
    {
		public List<urlParam> up = new List<urlParam>();
		public List<KeyValuePair<string, string>> channel = new List<KeyValuePair<string, string>>(); 

		public Form1()
        {
            InitializeComponent();
            Init();
		}

        private void Init()
        {
            up.Add(new urlParam() { id = 1, url = "http://apis.baidu.com/songshuxiansheng/news/news", param = "" });
            up.Add(new urlParam() { id = 2, url = "http://apis.baidu.com/3023/news/channel", param = "id={0}&page={1}" });
            up.Add(new urlParam() { id = 3, url = "http://apis.baidu.com/songshuxiansheng/real_time/search_news", param = "keyword={0}&page={1}&count={2}" });
            up.Add(new urlParam() { id = 4, url = "http://apis.baidu.com/txapi/keji/keji", param = "num={0}&page=1" });
            up.Add(new urlParam() { id = 5, url = "http://apis.baidu.com/cd_boco/chinanews/testnewsapi", param = "query={0}&device=pc&catid={1}&pagesize={2}&sid=10" });
            up.Add(new urlParam() { id = 6, url = "http://apis.baidu.com/acman/manfunsf/chaxun", param = "name={0}" });
            up.Add(new urlParam() { id = 7, url = "http://apis.baidu.com/acman/zhaiyanapi/tcrand", param = "fangfa=json" });
            up.Add(new urlParam() { id = 8, url = "http://apis.baidu.com/yunba/realtime_restful_api/publish", param =""});
            up.Add(new urlParam() { id = 9, url = "http://apis.baidu.com/avatardata/historytoday/lookup", param = "yue={0}&ri={1}&type={2}&page={3}&rows={4}&dtype=JOSN&format=false" });
            up.Add(new urlParam() { id = 10, url = "http://apis.baidu.com/avatardata/chengyu/lookup", param = "dtype=JOSN&id={0}" });
            up.Add(new urlParam() { id = 11, url = "http://apis.baidu.com/chazhao/md5decod/md5decod", param = "dmd5={0}" });

            this.url.DataSource = up;
            this.url.ValueMember = "id";
            this.url.DisplayMember = "url";
        }

		private void start_Click(object sender, EventArgs e)
        {
			try {
				var selectUrl=up.Where(p => p.id == int.Parse(this.url.SelectedValue.ToString())).FirstOrDefault();
                 string result ="";
                var keywords = this.keyword.Text;
                int count = int.Parse(this.Num.Text);
                 switch (selectUrl.id)
                 {
                     case 1:
                         result = request(selectUrl.url, keywords);
                         break;
                     case 2:
                         var val = this.channelDrop.SelectedValue.ToString();
                         result = request(selectUrl.url, string.Format(selectUrl.param, val, 1));
                         break;
                     case 3:
                         result = request(selectUrl.url, string.Format(selectUrl.param, keywords, 1,count));
                         break;
                     case 4:
                         result = request(selectUrl.url, string.Format(selectUrl.param, count));
                         break;
                     case 5:
                         result = request(selectUrl.url, string.Format(selectUrl.param, keywords));
                         break;
                     case 6:
                         result = request(selectUrl.url, string.Format(selectUrl.param, keywords));
                         break;
                     case 7:
                         result = request(selectUrl.url, selectUrl.param);
                         break;
                     case 8:
                         result = requestPost(selectUrl.url,"{'method':'publish', 'appkey': '5316bd7179b6570f2ca6e20b', 'seckey': 'sec-qaAQOCmuFL22b0mv78hcOEyc9DzB9q0zesIfBAereaN6FAcb', 'topic': 'test_topic', 'msg': 'msg:"+keywords+"'}");
                         break;
                     case 9:
                         var type = this.channelDrop.SelectedValue.ToString();
                         //type 1：国内国际大事件，2：民间事件包含部分国家大事件
                         result = request(selectUrl.url, string.Format(selectUrl.param, DateTime.Now.Month,DateTime.Now.Day,type,1,count));
                         break;
                     case 10:
                         result = request(selectUrl.url, string.Format(selectUrl.param, keywords));
                         break;
                     case 11:
                         result = request(selectUrl.url, string.Format(selectUrl.param, keywords));
                         break;
                     default:
                         break;
                 }
                 
				this.viewList.AppendText(result+"\r\t"+DateTime.Now.ToShortTimeString()+"\r\t");
			} catch ( Exception ex ) {
				MessageBox.Show(ex.Message);
			}
        }
		/// <summary>
		/// 发送HTTP请求
		/// </summary>
		/// <param name="url">请求的URL</param>
		/// <param name="param">请求的参数</param>
		/// <returns>请求结果</returns>
		public static string request(string url, string param) {
			string strURL = url + '?' + param;
			HttpWebRequest request;
			request = ( HttpWebRequest ) WebRequest.Create(strURL);
			request.Method = "GET";
			// 添加header
			request.Headers.Add("apikey", "b32f5eae026fd4bcc5e0e3c3b26aff83");
			HttpWebResponse response;
			response = ( HttpWebResponse ) request.GetResponse();
			Stream s;
			s = response.GetResponseStream();
			string StrDate = "";
			string strValue = "";
			StreamReader Reader = new StreamReader(s, Encoding.UTF8);
			while ( ( StrDate = Reader.ReadLine() ) != null ) {
				strValue += ConvertJsonString(StrDate) + "\r\n";
			}
			return strValue;
		}
        /// <summary>
        /// 发送HTTP请求
        /// </summary>
        /// <param name="url">请求的URL</param>
        /// <param name="param">请求的参数</param>
        /// <returns>请求结果</returns>
        public static string requestPost(string url, string param)
        {
            string strURL = url;
            System.Net.HttpWebRequest request;
            request = (System.Net.HttpWebRequest)WebRequest.Create(strURL);
            request.Method = "POST";
            // 添加header
            request.Headers.Add("apikey", "b32f5eae026fd4bcc5e0e3c3b26aff83");
            request.ContentType = "application/x-www-form-urlencoded";
            string paraUrlCoded = param;
            byte[] payload;
            payload = System.Text.Encoding.UTF8.GetBytes(paraUrlCoded);
            request.ContentLength = payload.Length;
            Stream writer = request.GetRequestStream();
            writer.Write(payload, 0, payload.Length);
            writer.Close();
            System.Net.HttpWebResponse response;
            response = (System.Net.HttpWebResponse)request.GetResponse();
            System.IO.Stream s;
            s = response.GetResponseStream();
            string StrDate = "";
            string strValue = "";
            StreamReader Reader = new StreamReader(s, Encoding.UTF8);
            while ((StrDate = Reader.ReadLine()) != null)
            {
                strValue += ConvertJsonString(StrDate) + "\r\n";
            }
            return strValue;
        }
		private static string ConvertJsonString(string str) {
			//格式化json字符串
			JsonSerializer serializer = new JsonSerializer();
			TextReader tr = new StringReader(str);
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
				return str;
			}
		}
		private void clear_Click(object sender, EventArgs e)
        {
			this.viewList.Text = string.Empty;
        }

        private void url_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.url.SelectedIndex == 1) {
                //找到服务器物理路径  
                string serverAppPath = System.Windows.Forms.Application.StartupPath;
                //string serverAppPath = @"d:\";
                //构成配置文件路径  
                string con_file_path = @"" + serverAppPath.Replace(@"\bin\Debug", @"\public") + @"\channel.json";

                //读取json文件  
                using (StreamReader sr = new StreamReader(con_file_path))
                {
                    try
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Converters.Add(new JavaScriptDateTimeConverter());
                        serializer.NullValueHandling = NullValueHandling.Ignore;

                        //构建Json.net的读取流  
                        JsonReader reader = new JsonTextReader(sr);
                        //对读取出的Json.net的reader流进行反序列化，并装载到模型中  
                        var list = serializer.Deserialize<List<Channel>>(reader);
                        list.ForEach(p =>
                        {
                            KeyValuePair<string, string> k_v = new KeyValuePair<string, string>(p.id, p.channel);
                            channel.Add(k_v);
                        });
                        this.channelDrop.DataSource = channel;
                        this.channelDrop.ValueMember = "key";
                        this.channelDrop.DisplayMember = "value";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }

            }
            else if (this.url.SelectedIndex == 4)
            {
                List<KeyValuePair<int, string>> dics = new List<KeyValuePair<int, string>>();
                dics.Add(new KeyValuePair<int, string>(1, "旅游"));
                dics.Add(new KeyValuePair<int, string>(2, "要闻"));
                dics.Add(new KeyValuePair<int, string>(3, "应用"));
                dics.Add(new KeyValuePair<int, string>(4, "游戏"));
                this.channelDrop.DataSource = dics;
                this.channelDrop.ValueMember = "key";
                this.channelDrop.DisplayMember = "value";
            }
            else if (this.url.SelectedIndex == 8)
            {
                List<KeyValuePair<int, string>> dics = new List<KeyValuePair<int, string>>();
                dics.Add(new KeyValuePair<int, string>(1, "国内国际大事件"));
                dics.Add(new KeyValuePair<int, string>(2, "民间事件包含部分国家大事件"));
                this.channelDrop.DataSource = dics;
                this.channelDrop.ValueMember = "key";
                this.channelDrop.DisplayMember = "value";
            }
            else {
                this.channelDrop.DataSource = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //找到服务器物理路径  
            string serverAppPath = System.Windows.Forms.Application.StartupPath;
            //string serverAppPath = @"d:\";
            //构成配置文件路径  
            string con_file_path = @"" + serverAppPath.Replace(@"\bin\Debug", @"\public") + @"\Permission.json";
            //读取json文件  
            using (StreamReader sr = new StreamReader(con_file_path,Encoding.UTF8))
            {
                try
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Converters.Add(new JavaScriptDateTimeConverter());
                    serializer.NullValueHandling = NullValueHandling.Ignore;

                    //构建Json.net的读取流  
                    JsonReader reader = new JsonTextReader(sr);
                    //对读取出的Json.net的reader流进行反序列化，并装载到模型中  
                    var list = serializer.Deserialize<List<myEnum>>(reader);
                    string str = "public enum Enum_Permission {\r\n";
                    list.ForEach(p =>
                    {
                        str+="///<summary>\r\n";
                        str +=  string.Format("///{0}\r\n",p.PermissionName);
                        str += "///</summary>\r\n";
                        str += string.Format("[EnumTitle(\"{0}\")]\r\n", p.PermissionName);
                        str += string.Format("{0}= {1},\r\n", p.PermissionkeyName, p.ID);
                    });
                    str += "}\r\n";
                    this.viewList.Text = str;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

    }
}
