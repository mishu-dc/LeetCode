using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTests
{
    [TestClass]
    public class ValidPalindromeTest
    {
        [TestMethod]
        public void ValidPalindromeTestmethod1()
        {
            ValidPalindrome pd = new ValidPalindrome();
            bool result = pd.IsPalindrome("   abc   ba");
            Assert.IsTrue(result);

            result = pd.IsPalindrome("   ; ; ; ; ; ,");
            Assert.IsTrue(result);

            result = pd.IsPalindrome("   ");
            Assert.IsTrue(result);

            result = pd.IsPalindrome("A man, a plan, a canal: Panama");
            Assert.IsTrue(result);

            result = pd.IsPalindrome("race a car");
            Assert.IsFalse(result);
        }
    }
}
