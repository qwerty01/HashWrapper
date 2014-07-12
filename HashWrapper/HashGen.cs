using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashWrapper
{
    public class HashGen
    {
        private static MD5 md5;
        private static SHA1 sha1;
        private static SHA256 sha2;
        private static SHA512 sha512;

        static HashGen()
        {
            Initialize();
        }

        public static void Initialize()
        {
            md5 = System.Security.Cryptography.MD5.Create();
            sha1 = System.Security.Cryptography.SHA1.Create();
            sha2 = System.Security.Cryptography.SHA256.Create();
            sha512 = System.Security.Cryptography.SHA512.Create();
        }
        public static void Dispose()
        {
            md5.Dispose();
        }
        public static string ToString(byte[] b)
        {
            string ret = "";
            foreach (byte bb in b)
                ret += bb.ToString("X");
            return ret;
        }

        public static byte[] MD5(string data)
        {
            return MD5(UnicodeEncoding.UTF8.GetBytes(data));
        }
        public static byte[] MD5(FileInfo file)
        {
            using (var s = file.OpenRead())
            {
                return MD5(s);
            }
        }
        public static byte[] MD5(byte[] data)
        {
            using (var s = new MemoryStream(data))
            {
                return MD5(s);
            }
        }
        public static byte[] MD5(Stream data)
        {
            return md5.ComputeHash(data);
        }

        public static byte[] SHA1(string data)
        {
            return SHA1(UnicodeEncoding.UTF8.GetBytes(data));
        }
        public static byte[] SHA1(FileInfo file)
        {
            using (var s = file.OpenRead())
            {
                return SHA1(s);
            }
        }
        public static byte[] SHA1(byte[] data)
        {
            using (var s = new MemoryStream(data))
            {
                return SHA1(s);
            }
        }
        public static byte[] SHA1(Stream data)
        {
            return sha1.ComputeHash(data);
        }

        public static byte[] SHA2(string data)
        {
            return SHA2(UnicodeEncoding.UTF8.GetBytes(data));
        }
        public static byte[] SHA2(FileInfo file)
        {
            using (var s = file.OpenRead())
            {
                return SHA2(s);
            }
        }
        public static byte[] SHA2(byte[] data)
        {
            using (var s = new MemoryStream(data))
            {
                return SHA2(s);
            }
        }
        public static byte[] SHA2(Stream data)
        {
            return sha2.ComputeHash(data);
        }

        public static byte[] SHA512(string data)
        {
            return SHA512(UnicodeEncoding.UTF8.GetBytes(data));
        }
        public static byte[] SHA512(FileInfo file)
        {
            using (var s = file.OpenRead())
            {
                return SHA512(s);
            }
        }
        public static byte[] SHA512(byte[] data)
        {
            using (var s = new MemoryStream(data))
            {
                return SHA512(s);
            }
        }
        public static byte[] SHA512(Stream data)
        {
            return sha512.ComputeHash(data);
        }
    }
}
