using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace UnitTests
{
    [TestClass]
    public class ArraytoBinarySearchTreeTest
    {
        [TestMethod]
        public void ArraytoBinarySearchTreeTestMethod1()
        {
            ArraytoBinarySearchTree tree = new ArraytoBinarySearchTree();
            tree.SortedArrayToBST(new int[] { -10, -3, 0, 5, 9 });
        }
    }
}
