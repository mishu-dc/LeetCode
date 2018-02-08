using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace UnitTests
{
    [TestClass]
    public class JudgeRouteCircleTest
    {
        [TestMethod]
        public void JudgeRouteCircleTestMethod1()
        {
            JudgeRouteCircle circle = new JudgeRouteCircle();
            bool result = circle.JudgeCircle("LLRRUUDD");
            Assert.AreEqual(true, result);
        }
    }
}
