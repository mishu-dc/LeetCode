using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace UnitTests
{
    [TestClass]
    public class TwoSum2Test
    {
        [TestMethod]
        public void TwoSum2TestMethod1()
        {
            TwoSum2 twoSum = new TwoSum2();
            int[] result = twoSum.TwoSumByBinarySearch(new int[] { 2, 3, 4 }, 6);
            CollectionAssert.AreEqual(result, new int[] { 1, 3 });
        }

        [TestMethod]
        public void TwoSum2TestMethod2()
        {
            TwoSum2 twoSum = new TwoSum2();
            int[] result = twoSum.TwoSumFaster(new int[] { 2, 3, 4 }, 6);
            CollectionAssert.AreEqual(result, new int[] { 1, 3 });
        }

        [TestMethod]
        public void TwoSum2TestMethod3()
        {
            TwoSum2 twoSum = new TwoSum2();
            int[] result = twoSum.TwoSumFaster(new int[] { 1, 1, 4 }, 2);
            CollectionAssert.AreEqual(result, new int[] { 1, 2 });
        }
    }
}
