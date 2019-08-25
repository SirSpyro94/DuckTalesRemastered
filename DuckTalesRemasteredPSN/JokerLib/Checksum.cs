using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace JokerLib
{
    public class Checksum
    {
        public static byte[] SHA1(byte[] buffer)
        {
            return new SHA1CryptoServiceProvider().ComputeHash(buffer);
        }

        public static byte[] MD5(byte[] buffer)
        {
            return new MD5CryptoServiceProvider().ComputeHash(buffer);
        }

        public static byte[] CRC32(byte[] buffer, uint polynomial = 0xedb88320, uint seed = 0xffffffff)
        {
            return new Crc32(polynomial, seed).ComputeHash(buffer);
        }

        public static byte[] HMACSHA1(byte[] buffer, byte[] key = null)
        {
            if (key != null)
                return new HMACSHA1(key).ComputeHash(buffer);
            return new HMACSHA1().ComputeHash(buffer);
        }
    }
}
