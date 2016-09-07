using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace powerShellTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void run_btn_Click(object sender, EventArgs e)
        {
            string command=this.command_text.Text.Trim();
            if (!string.IsNullOrWhiteSpace(command)) {
                if (command.IndexOf(@"\r\n") < 0)
                    this.return_text.Text = powerShell.RunScript(command);
                else {
                    command=command.Replace("\r\n","`");
                    string[] commands = command.Split('`');
                    List<string> list = new List<string>();
                    foreach (var item in commands)
                    {
                        if (!string.IsNullOrWhiteSpace(item.Trim())) {
                            list.Add(item.Trim());
                        }
                    }
                    if (list.Count() > 0) {
                       this.return_text.Text= new powerShell().RunScript(list);
                    }
                }
            }
        }

        private void clearCom_btn_Click(object sender, EventArgs e)
        {
            this.command_text.Text = string.Empty;
        }

        private void clearReturn_btn_Click(object sender, EventArgs e)
        {
            this.return_text.Text = string.Empty;
        }
    }
}
