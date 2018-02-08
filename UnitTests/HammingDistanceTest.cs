using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;


namespace UnitTests
{
    [TestClass]
    public class HammingDistanceTest
    {
        [TestMethod]
        public void HammingDistanceTestMethod()
        {
            HammingDistance distance = new HammingDistance();
            int value = distance.Solution(1, 400);
            Assert.Equals(4, value);
        }
    }
}
