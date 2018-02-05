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
        public void LongestSubstringTestMethod1()
        {
            LongestSubstring subString = new LongestSubstring();
            int length = subString.Execute("abcdef");
            Assert.AreEqual(length, 6);
        }

        [TestMethod]
        public void LongestSubstringTestMethod2()
        {
            LongestSubstring subString = new LongestSubstring();
            int length = subString.Execute("abcabcabcabc");
            Assert.AreEqual(length, 3);
        }

        [TestMethod]
        public void LongestSubstringTestMethod3()
        {
            LongestSubstring subString = new LongestSubstring();
            int length = subString.Execute("abcabcabcabcx");
            Assert.AreEqual(length, 4);
        }

        [TestMethod]
        public void LongestSubstringTestMethod4()
        {
            LongestSubstring subString = new LongestSubstring();
            int length = subString.Execute("a");
            Assert.AreEqual(length, 1);
        }
    }
}
