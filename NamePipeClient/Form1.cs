using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Pipes;
using System.Security.Principal;
using System.IO;

namespace NamePipeClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.FormClosing += Form1_FormClosing;
        }



        NamedPipeClientStream pipeClient = new NamedPipeClientStream("192.168.1.55", "testPipe", PipeDirection.InOut, PipeOptions.Asynchronous, TokenImpersonationLevel.None);
        StreamWriter sw = null;

        void Form1_Load(object sender, EventArgs e)
        {
            pipeClient.Connect();
            sw = new StreamWriter(pipeClient);
            sw.AutoFlush = true;
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sw.WriteLine("close");
            pipeClient.Close();
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            sw.WriteLine(msg_text.Text);
        }
    }
}
