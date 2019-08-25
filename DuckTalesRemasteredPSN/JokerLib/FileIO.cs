using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace JokerLib
{
    public class FileIO : IDisposable 
    {
        private string filePath;
        private Stream stream;
        private BinaryReader reader;
        private BinaryWriter writer;
        private bool bigEndian = false;

        public FileIO(string filePath, bool bigEndian = false)
        {
            this.filePath = filePath;
            this.stream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            this.reader = new BinaryReader(stream);
            this.writer = new BinaryWriter(stream);
            this.bigEndian = bigEndian;
        }

        public FileIO(byte[] buffer, bool bigEndian = false)
        {
            this.stream = new MemoryStream(buffer);
            this.reader = new BinaryReader(stream);
            this.writer = new BinaryWriter(stream);
            this.bigEndian = bigEndian;
        }

        public FileIO(bool bigEndian = false)
        {
            this.filePath = Path.GetTempFileName();
            this.stream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);
            this.reader = new BinaryReader(stream);
            this.writer = new BinaryWriter(stream);
            this.bigEndian = bigEndian;
        }

        public static FileIO OpenIO(string title, string filter, bool bigEndian = false)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = title;
            ofd.Filter = filter;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return new FileIO(ofd.FileName, bigEndian);
            }
            return null;
        }

        public byte ReadByte()
        {
            return this.reader.ReadByte();
        }

        public byte[] ReadBytes(int count)
        {
            return this.reader.ReadBytes(count);
        }

        public int ReadInt32()
        {
            byte[] array = ReadBytes(4);
            if (BigEndian)
                Array.Reverse(array);
            return BitConverter.ToInt32(array, 0);
        }

        public uint ReadUInt32()
        {
            byte[] array = ReadBytes(4);
            if (BigEndian)
                Array.Reverse(array);
            return BitConverter.ToUInt32(array, 0);
        }

        public short ReadInt16()
        {
            byte[] array = ReadBytes(2);
            if (BigEndian)
                Array.Reverse(array);
            return BitConverter.ToInt16(array, 0);
        }

        public ushort ReadUInt16()
        {
            byte[] array = ReadBytes(2);
            if (BigEndian)
                Array.Reverse(array);
            return BitConverter.ToUInt16(array, 0);
        }

        public long ReadInt64()
        {
            byte[] array = ReadBytes(8);
            if (BigEndian)
                Array.Reverse(array);
            return BitConverter.ToInt64(array, 0);
        }

        public ulong ReadUInt64()
        {
            byte[] array = ReadBytes(8);
            if (BigEndian)
                Array.Reverse(array);
            return BitConverter.ToUInt64(array, 0);
        }

        public int SeekNReadInt32(long offset)
        {
            long tmp = this.Offset;
            this.Offset = offset;
            int num = ReadInt32();
            this.Offset = tmp;
            return num;
        }

        public uint SeekNReadUInt32(long offset)
        {
            long tmp = this.Offset;
            this.Offset = offset;
            uint num = ReadUInt32();
            this.Offset = tmp;
            return num;
        }

        public long SeekNReadInt64(long offset)
        {
            long tmp = this.Offset;
            this.Offset = offset;
            long num = ReadInt64();
            this.Offset = tmp;
            return num;
        }

        public ulong SeekNReadUInt64(long offset)
        {
            long tmp = this.Offset;
            this.Offset = offset;
            ulong num = ReadUInt64();
            this.Offset = tmp;
            return num;
        }

        public byte[] SeekNReadBytes(long offset, int count)
        {
            long tmp = this.Offset;
            this.Offset = offset;
            byte[] buffer = this.ReadBytes(count);
            this.Offset = tmp;
            return buffer;
        }

        public void Write(byte[] value)
        {
            this.writer.Write(value, 0, value.Length);
        }

        public void Write(byte value)
        {
            this.writer.Write(value);
        }

        public void Write(object value)
        {
            byte[] c = null;
            if (value.GetType() == typeof(int))
                c = BitConverter.GetBytes((int)value);
            else if (value.GetType() == typeof(uint))
                c = BitConverter.GetBytes((uint)value);
            else if (value.GetType() == typeof(ushort))
                c = BitConverter.GetBytes((ushort)value);
            else if (value.GetType() == typeof(long))
                c = BitConverter.GetBytes((long)value);
            else if (value.GetType() == typeof(ulong))
                c = BitConverter.GetBytes((ulong)value);
            else if (value.GetType() == typeof(byte))
                c = BitConverter.GetBytes((byte)value);
            if (BigEndian)
                Array.Reverse(c);
            this.Write(c);
        }

        public bool BigEndian
        {
            get { return this.bigEndian; }
            set { this.bigEndian = value; }
        }

        public byte[] ToArray()
        {
            if (this.stream.GetType() == typeof(MemoryStream))
                return ((MemoryStream)stream).ToArray();
            else
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                return buffer;
            }
        }

        public long Offset
        {
            get
            {
                return this.stream.Position;
            }
            set
            {
                this.stream.Position = value;
            }
        }

        public long Length
        {
            get
            {
                return this.stream.Length;
            }
            set
            {
                this.stream.SetLength(value);
            }
        }

        public void Close()
        {
            this.stream.Close();
            this.reader.Close();
           this. writer.Close();
        }

        public void Dispose()
        {
            this.Close();
        }
    }
}
