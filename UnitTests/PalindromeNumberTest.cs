using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace UnitTests
{
    [TestClass]
    public class PalindromeNumberTest
    {
        [TestMethod]
        public void PalindromeNumberTestMethod1()
        {
            PalindromeNumber number = new PalindromeNumber();
            bool result = number.IsPalindrome(-2147483648);
            Assert.AreEqual(false, result);
        }
    }
}
