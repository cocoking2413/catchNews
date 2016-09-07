using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NamePipeService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        NamedPipeServerStream pipeService = new NamedPipeServerStream("testPipe", PipeDirection.InOut, 4, PipeTransmissionMode.Message, PipeOptions.Asynchronous);

        void Form1_Load(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(delegate {
                pipeService.BeginWaitForConnection((o) => {
                    NamedPipeServerStream server = (NamedPipeServerStream)o.AsyncState;
                    server.EndWaitForConnection(o);
                    StreamReader sr = new StreamReader(server);
                    StreamWriter sw = new StreamWriter(server);
                    string result = null;
                    string clientName = server.GetImpersonationUserName();
                    while (true) {
                        result = sr.ReadLine();
                        if (result == null )
                            break;
                        this.Invoke((MethodInvoker)delegate { msg_list.Items.Add(clientName+":"+result); });
                        if (result == "close")
                            break;
                    }
                },pipeService);
            });
        }
    }
}
