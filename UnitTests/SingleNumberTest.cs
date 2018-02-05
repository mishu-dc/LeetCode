using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace UnitTests
{
    [TestClass]
    public class SingleNumberTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            SingleNumber number = new SingleNumber();
            int result = number.ExecuteUsingXorFastest(new int[] { 1, 2, 3, 1, 2, 3, 5 });
            Assert.AreEqual(result, 5);
        }
    }
}
