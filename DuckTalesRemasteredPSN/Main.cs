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

        public enum GameVersion
        {
            Steam,
            Console
        }

        public enum GameOffsets : long
        {
            Console_Difficulty = 0x19,
            Console_Checksum_Start = 0x10,
            Console_Checksum_Count = 0x400,
            Console_Checksum = 0,
            Steam_Difficulty = 0x89,
        }

        private FileIO IO;
        private GameVersion Version;

        private void btnLoad_Click(object sender, EventArgs e)
        {
            IO = FileIO.OpenIO("Open File", "", true);
            if (IO != null)
            {
                if (IO.Length == 0x440)
                {
                    MessageBox.Show("Unsupported Version");
                    return;
                }
                else if (IO.Length == 0x410 || IO.Length == 0x410)
                {
                    IO.Offset = (long)GameOffsets.Console_Difficulty;
                    cbDifficulty.SelectedItem = (string)Difficulty((byte)IO.ReadByte(), false);
                    Version = GameVersion.Console;
                }
                else if (IO.Length == 0x480)
                {
                    IO.Offset = (long)GameOffsets.Steam_Difficulty;
                    cbDifficulty.SelectedItem = (string)Difficulty((byte)IO.ReadByte(), false);
                    Version = GameVersion.Steam;
                }
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
            if (Version == GameVersion.Steam)
            {
                IO.Offset = (long)GameOffsets.Steam_Difficulty;
                IO.Write((byte)Difficulty((string)cbDifficulty.SelectedItem.ToString(), true));
            }
            else if (Version == GameVersion.Console)
            {
                IO.Offset = (long)GameOffsets.Console_Difficulty;
                IO.Write((byte)Difficulty((string)cbDifficulty.SelectedItem.ToString(), true));
                IO.Offset = (long)GameOffsets.Console_Checksum_Start;
                byte[] buffer = IO.ReadBytes((int)GameOffsets.Console_Checksum_Count);
                ulong hash = DuckTales.Compute(buffer);
                IO.Offset = (long)GameOffsets.Console_Checksum;
                IO.Write((ulong)hash);
            }
            IO.Close();
            MessageBox.Show("Saved!");
        }
    }
}
