using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace UnitTests
{
    [TestClass]
    public class LongestPalindromeTest
    {
        [TestMethod]
        public void LongestPalindromeTestMethod1()
        {
            LongestPalindrome palindrom = new LongestPalindrome();
            int result = palindrom.Execute("abccccdd");
            Assert.AreEqual(7, result);
        }
    }
}
