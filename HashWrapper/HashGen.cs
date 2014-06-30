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
        public byte[] MD5(string data)
        {
            return MD5(UnicodeEncoding.UTF8.GetBytes(data));
        }
        public byte[] MD5(FileInfo file)
        {
            using (var s = file.OpenRead())
            {
                return MD5(s);
            }
        }
        public byte[] MD5(byte[] data)
        {
            using (var s = new MemoryStream(data))
            {
                return MD5(s);
            }
        }
        public byte[] MD5(Stream data)
        {
            using (MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                return md5.ComputeHash(data);
            }
        }

        public byte[] SHA1(string data)
        {
            return SHA1(UnicodeEncoding.UTF8.GetBytes(data));
        }
        public byte[] SHA1(FileInfo file)
        {
            using (var s = file.OpenRead())
            {
                return SHA1(s);
            }
        }
        public byte[] SHA1(byte[] data)
        {
            using (var s = new MemoryStream(data))
            {
                return SHA1(s);
            }
        }
        public byte[] SHA1(Stream data)
        {
            using (var sha1 = new SHA1CryptoServiceProvider())
            {
                return sha1.ComputeHash(data);
            }
        }

        public byte[] SHA2(string data)
        {
            return SHA2(UnicodeEncoding.UTF8.GetBytes(data));
        }
        public byte[] SHA2(FileInfo file)
        {
            using (var s = file.OpenRead())
            {
                return SHA2(s);
            }
        }
        public byte[] SHA2(byte[] data)
        {
            using (var s = new MemoryStream(data))
            {
                return SHA2(s);
            }
        }
        public byte[] SHA2(Stream data)
        {
            using (var sha2 = new SHA256CryptoServiceProvider())
            {
                return sha2.ComputeHash(data);
            }
        }
    }
}
