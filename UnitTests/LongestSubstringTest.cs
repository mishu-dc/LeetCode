using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solutions;

namespace UnitTests
{
    [TestClass]
    public class LongestSubstringTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            LongestSubstring subString = new LongestSubstring();
            int length = subString.Execute("abcdef");
            Assert.AreEqual(length, 6);
        }

        [TestMethod]
        public void TestMethod2()
        {
            LongestSubstring subString = new LongestSubstring();
            int length = subString.Execute("abcabcabcabc");
            Assert.AreEqual(length, 3);
        }

        [TestMethod]
        public void TestMethod3()
        {
            LongestSubstring subString = new LongestSubstring();
            int length = subString.Execute("abcabcabcabcx");
            Assert.AreEqual(length, 4);
        }

        [TestMethod]
        public void TestMethod4()
        {
            LongestSubstring subString = new LongestSubstring();
            int length = subString.Execute("a");
            Assert.AreEqual(length, 1);
        }
    }
}
