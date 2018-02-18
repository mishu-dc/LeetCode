using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace UnitTests.Array
{
    [TestClass]
    public class FindDisappearedNumbersTest
    {
        [TestMethod]
        public void FindDisappearedNumbersTestMethod1()
        {
            FindAllNumbers findDisappearedNumbers = new FindAllNumbers();
            findDisappearedNumbers.FindDisappearedNumbers(new int[] { 1, 2, 3, 6, 5, 5, 5, 5, 5, 10 });
        }
    }
}
