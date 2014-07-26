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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HashWrapper;

namespace HashTester
{
    [TestClass]
    public class HashGenTests
    {
        private void CompareExpected(byte[] output, byte[] expected)
        {
            if (output.Length != expected.Length) // Check that the lengths are the same
                Assert.Fail("Output and expected are different sizes\n  output: " + output.Length + "\n  expected: " + expected.Length);
            for (int i = 0; i < expected.Length; i++) // Check that the content is the same
                if (output[i] != expected[i])
                    Assert.Fail("Output value does not match expected!\n  Index: " + i + "\n  Output: 0x" + ((int)output[i]).ToString("X") + "\n  Expected: 0x" + ((int)expected[i]).ToString("X"));
        }
        [TestMethod]
        public void MD5TestCase_String_1()
        {
            // Test conditions
            string data = "The quick brown fox jumps over the lazy dog";
            byte[] expected = { 0x9e, 0x10, 0x7d, 0x9d, 0x37, 0x2b, 0xb6, 0x82, 0x6b, 0xd8, 0x1d, 0x35, 0x42, 0xa4, 0x19, 0xd6 };
            
            // Test
            try
            {
                HashGen.Initialize();
                byte[] hash = HashGen.MD5(data);
                StringAssert.Equals(hash, expected);
                CompareExpected(hash, expected);
            }
            catch(Exception e)
            {
                Assert.Fail("Exception was thrown:\n" + e.Message);
            }
            finally
            {
                HashGen.Dispose();
            }
        }
    }
}
