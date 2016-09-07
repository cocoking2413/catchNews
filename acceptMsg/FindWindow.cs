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

namespace acceptMsg
{
    public partial class FindWindow : Form
    {
        public FindWindow()
        {
            InitializeComponent();
        }

        public struct CopyDataStruct {
            public IntPtr dwData;
            public int cbData;

            [MarshalAs(UnmanagedType.LPStr)]
            public string lpData;
        }

        private const int VM_COPYDATA = 0x004A;
        //接收消息方法
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == VM_COPYDATA) {
                CopyDataStruct cds = (CopyDataStruct)m.GetLParam(typeof(CopyDataStruct));
                this.accept_text.Text=cds.lpData.ToString();
            }
            base.WndProc(ref m);
        }

    }
}
