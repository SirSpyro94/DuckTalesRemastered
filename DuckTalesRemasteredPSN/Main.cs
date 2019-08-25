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
            Console_Total_Money = 0xD0,
            Console_Characters = 0xD8,

            Steam_Difficulty = 0x89,
            Steam_Total_Money = 0x1C8,
            Steam_Characters = 0x1D0
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
                else if (IO.Length == 0x410)
                {
                    IO.Offset = (long)GameOffsets.Console_Difficulty;
                    cbDifficulty.SelectedItem = (string)Difficulty((byte)IO.ReadByte(), false);
                    IO.Offset = (long)GameOffsets.Console_Total_Money;
                    txtTMoney.Text = IO.ReadInt32().ToString();
                    IO.Offset = (long)GameOffsets.Console_Characters;
                    if (IO.ReadUInt32() == 1048575)
                        cbUnlockAllChar.Checked = true;
                    if (IO.ReadUInt32() == 1048575)
                        cbConceptArt.Checked = true;
                    if (IO.ReadUInt32() == 1048575)
                        cbSketches.Checked = true;
                    if (IO.ReadUInt32() == 1048575)
                        cbPencil.Checked = true;
                    if (IO.ReadUInt32() == 1048575)
                        cbPaintings.Checked = true;
                    if (IO.ReadUInt32() == 1048575)
                        cbMusic.Checked = true;
                    if (IO.ReadUInt32() == 1048575)
                        cbTVShow1.Checked = true;
                    if (IO.ReadUInt32() == 1048575)
                        cbTVShow2.Checked = true;
                    Version = GameVersion.Console;
                }
                else if (IO.Length == 0x480)
                {
                    IO.BigEndian = false;
                    IO.Offset = (long)GameOffsets.Steam_Difficulty;
                    cbDifficulty.SelectedItem = (string)Difficulty((byte)IO.ReadByte(), false);
                    IO.Offset = (long)GameOffsets.Steam_Total_Money;
                    txtTMoney.Text = IO.ReadInt32().ToString();
                    IO.Offset = (long)GameOffsets.Steam_Characters;
                    if (IO.ReadUInt32() == 1048575)
                        cbUnlockAllChar.Checked = true;
                    if (IO.ReadUInt32() == 1048575)
                        cbConceptArt.Checked = true;
                    if (IO.ReadUInt32() == 1048575)
                        cbSketches.Checked = true;
                    if (IO.ReadUInt32() == 1048575)
                        cbPencil.Checked = true;
                    if (IO.ReadUInt32() == 1048575)
                        cbPaintings.Checked = true;
                    if (IO.ReadUInt32() == 1048575)
                        cbMusic.Checked = true;
                    if (IO.ReadUInt32() == 1048575)
                        cbTVShow1.Checked = true;
                    if (IO.ReadUInt32() == 1048575)
                        cbTVShow2.Checked = true;
                    Version = GameVersion.Steam;
                }
                Text = string.Format("DuckTales Remastered - Save [{0}]", Version.ToString());
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
                IO.Offset = (long)GameOffsets.Steam_Total_Money;
                IO.Write((uint)uint.Parse(txtTMoney.Text));
                IO.Offset = 0x1cc;
                IO.Write((uint)4294967295);
                IO.Offset = (long)GameOffsets.Steam_Characters;
                if (cbUnlockAllChar.Checked)
                    IO.Write((uint)1048575);
                if (cbConceptArt.Checked)
                    IO.Write((uint)1048575);
                if (cbSketches.Checked)
                    IO.Write((uint)1048575);
                if (cbPencil.Checked)
                    IO.Write((uint)1048575);
                if (cbPaintings.Checked)
                    IO.Write((uint)1048575);
                if (cbMusic.Checked)
                    IO.Write((uint)1048575);
                if (cbTVShow1.Checked)
                    IO.Write((uint)1048575);
                if (cbTVShow2.Checked)
                    IO.Write((uint)1048575);
            }
            else if (Version == GameVersion.Console)
            {
                IO.Offset = (long)GameOffsets.Console_Difficulty;
                IO.Write((byte)Difficulty((string)cbDifficulty.SelectedItem.ToString(), true));
                IO.Offset = (long)GameOffsets.Console_Total_Money;
                IO.Write((uint)uint.Parse(txtTMoney.Text));
                IO.Offset = 0xD4;
                IO.Write((uint)4294967295);
                IO.Offset = (long)GameOffsets.Console_Characters;
                if (cbUnlockAllChar.Checked)
                    IO.Write((uint)1048575);
                if (cbConceptArt.Checked)
                    IO.Write((uint)1048575);
                if (cbSketches.Checked)
                    IO.Write((uint)1048575);
                if (cbPencil.Checked)
                    IO.Write((uint)1048575);
                if (cbPaintings.Checked)
                    IO.Write((uint)1048575);
                if (cbMusic.Checked)
                    IO.Write((uint)1048575);
                if (cbTVShow1.Checked)
                    IO.Write((uint)1048575);
                if (cbTVShow2.Checked)
                    IO.Write((uint)1048575);
                IO.Offset = (long)GameOffsets.Console_Checksum_Start;
                byte[] buffer = IO.ReadBytes((int)GameOffsets.Console_Checksum_Count);
                ulong hash = DuckTales.Compute(buffer);
                IO.Offset = (long)GameOffsets.Console_Checksum;
                IO.Write((ulong)hash);
            }
            IO.Close();
            MessageBox.Show("Saved!");
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox2.Controls)
                if (c is CheckBox)
                    ((CheckBox)c).Checked = true;
        }
    }
}
