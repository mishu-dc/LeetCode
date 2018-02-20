using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace UnitTests.Tree
{
    [TestClass]
    public class FindLeavesOfBinaryTreeTest: UnitTestBase
    {
        [TestMethod]
        public void FindLeavesOfBinaryTreeTestMethod1()
        {
            FindLeavesOfBinaryTree tree = new FindLeavesOfBinaryTree();
            tree.FindLeaves(base.GetTreeNode(new int?[] { 1, 2, 3, 4, 5 }));
        }
    }
}
