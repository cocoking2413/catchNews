using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendNotice
{
    public partial class SendMsg : Form
    {
        public SendMsg()
        {
            InitializeComponent();
        }

        public struct CopyDataStruct {
            public IntPtr dwData;
            public int cbData;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpData;
        }
        public const int VM_COPYDATA = 0x004A;

        [DllImport("User32.dll",EntryPoint="FindWindow")]
        private static extern int FindWindow(string lpClassName, string lpWindowName);

        //在DLL库中的发送消息函数
        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(
            int hWnd,
            int Msg,
            int wParam,
            ref CopyDataStruct lParam
            );
        private void send_btn_Click(object sender, EventArgs e)
        {
            //将文本框中的值， 发送给接收端           
            string strURL = this.msg.Text;
            CopyDataStruct cds;
            cds.dwData = (IntPtr)1; //这里可以传入一些自定义的数据，但只能是4字节整数      
            cds.lpData = strURL;    //消息字符串
            cds.cbData = System.Text.Encoding.Default.GetBytes(strURL).Length + 1;  //注意，这里的长度是按字节来算的
            SendMessage(FindWindow(null, "FindWindow"), VM_COPYDATA, 0, ref cds);       // 这里要修改成接收窗口的标题“接收端”
            //this.Close();
        }
    }
}
