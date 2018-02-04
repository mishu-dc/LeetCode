using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace UnitTests
{
    [TestClass]
    public class RemoveNthNodeTest:UnitTestBase
    {
        [TestMethod]
        public void TestMethod1()
        {
            RemoveNthNode rnm = new RemoveNthNode();
            ListNode res = rnm.RemoveNthNodeFromEndOptimized(base.GetListNode(new int[] { 1,2,3,4,5 }), 5);
            Assert.IsNotNull(res);
            Assert.IsTrue(res.Equals(base.GetListNode(new int[] { 2, 3, 4, 5 })));
        }
    }
}
