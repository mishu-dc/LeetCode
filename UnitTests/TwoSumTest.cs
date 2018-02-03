using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace UnitTests
{
    [TestClass]
    public class TwoSumTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            TwoSum sum = new TwoSum();
            int[] res = sum.Execute(new int[] { -1, -2, -3, -6 }, -8);
            CollectionAssert.AreEqual(res, new int[] { 1, 3 });
        }

        [TestMethod]
        public void TestMethod2()
        {
            TwoSum sum = new TwoSum();
            int[] res = sum.Execute(new int[] { 1, 2, 3 }, 4);
            CollectionAssert.AreEqual(res, new int[] { 0, 2 });
        }
    }
}
