using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace UnitTests
{
    [TestClass]
    public class ImplementStrStrTest
    {
        [TestMethod]
        public void ImplementStrStrTestMethod1()
        {
            ImplementStrStr strstr = new ImplementStrStr();
            int result = strstr.StrStr("xxbc", "bc");
            Assert.AreEqual(result, 2);

            result = strstr.StrStr("xxxx", "bc");
            Assert.AreEqual(result, -1);
        }
    }
}
