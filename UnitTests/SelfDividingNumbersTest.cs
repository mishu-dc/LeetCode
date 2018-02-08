using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace UnitTests
{
    [TestClass]
    public class SelfDividingNumbersTest
    {
        [TestMethod]
        public void SelfDividingNumbersTestMethod1()
        {
            SelfDividingNumbers sdns = new SelfDividingNumbers();
            sdns.Solution(1, 22);
        }
    }
}
