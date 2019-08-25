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
            IO = FileIO.OpenIO("Open File", "|savedata.sav", true);
            if (IO != null)
            {
                IO.Offset = 0x19;
                comboBox1.SelectedItem = (string)Difficulty((byte)IO.ReadByte(), false);
            }
        }

        private object Difficulty(object value, bool returnByte = false)
        {
            object output = null;
            if (returnByte != true)
            {
                switch ((byte)value)
                {
                    case 0:
                        output = "Easy";
                        break;
                    case 1:
                        output = "Medium";
                        break;
                    case 2:
                        output = "Hard";
                        break;
                }
                return Convert.ToString(output);
            }
            else
            {
                switch ((string)value)
                {
                    case "Easy":
                        output = 0x00;
                        break;
                    case "Medium":
                        output = 0x01;
                        break;
                    case "Hard":
                        output = 0x02;
                        break;
                }
                return Convert.ToByte(output);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IO.Offset = 0x19;
            IO.Write((byte)Difficulty((string)comboBox1.SelectedItem.ToString(), true));
            IO.Offset = 16;
            byte[] buffer = IO.ReadBytes(0x400);
            ulong hash = DuckTales.Compute(buffer);
            IO.Offset = 0;
            IO.Write((ulong)hash);
            IO.Close();
            MessageBox.Show("Saved!");
        }
    }
}
