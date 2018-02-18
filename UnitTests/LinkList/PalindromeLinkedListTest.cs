using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace UnitTests
{
    [TestClass]
    public class PalindromeLinkedListTest : UnitTestBase
    {
        [TestMethod]
        public void PalindromeLinkedListTestMethod1()
        {
            PalindromeLinkedList list = new PalindromeLinkedList();
            bool result = list.IsPalindrome(base.GetListNode(new int[] { 1, 2, 3, 2, 1 }));
            Assert.AreEqual(true, result);
        }
    }
}
