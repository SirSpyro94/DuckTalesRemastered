using JokerLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuckTalesRemasteredPSN
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private FileIO IO;

        private void btnLoad_Click(object sender, EventArgs e)
        {
            IO = FileIO.OpenIO("Open File", "", true);
            if (IO != null)
            {
                IO.Offset = 0xD0;
                txtMoney.Text = IO.ReadInt32().ToString();
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            txtMoney.Text = "99999999";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IO.Offset = 0xD0;
            IO.Write(uint.Parse(txtMoney.Text));
            IO.Offset = 16;
            byte[] buffer = IO.ReadBytes(0x400);
            ulong hash = DuckTales.Compute(buffer);
            IO.Offset = 0;
            IO.Write((ulong)hash);
            IO.Close();
        }
    }
}
