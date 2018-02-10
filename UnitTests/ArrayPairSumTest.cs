using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace UnitTests
{
    [TestClass]
    public class ArrayPairSumTest
    {
        [TestMethod]
        public void ArrayPairSumTestTestMethod1()
        {
            ArrayPairSum arrayPairSum = new ArrayPairSum();
            int sum = arrayPairSum.Solution(new int[] { 1,2,3,4,5,6 });
            Assert.AreEqual(9, sum);
        }
    }
}
