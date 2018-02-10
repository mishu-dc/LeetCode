using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace UnitTests
{
    [TestClass]
    public class ReverseWordsTest
    {
        [TestMethod]
        public void ReverseWordsTestMethod1()
        {
            ReverseWords reverseWords = new ReverseWords();
            string result = reverseWords.Execute("hello world");
            Assert.AreEqual("olleh dlrow", result);
        }
    }
}
