using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace UnitTests
{
    [TestClass]
    public class SymmetricTreeTest: UnitTestBase
    {
        [TestMethod]
        public void SymmetricTreeTestMethod1()
        {
            SymmetricTree tree = new SymmetricTree();
            bool result = tree.IsSymmetric(base.GetTreeNode(new int?[] { 1, 2, 2, 3, 4, 4, 3 }));
            Assert.AreEqual(true, result);
        }
    }
}
