<<<<<<< HEAD
﻿/*
 * The MIT License (MIT)
 * 
 * Copyright (c) 2014 Qwerty01 (http://github.com/qwerty01)
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */
using System;
=======
﻿using System;
>>>>>>> origin/WIP
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
