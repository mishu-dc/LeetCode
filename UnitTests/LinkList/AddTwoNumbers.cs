using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace UnitTests
{
    [TestClass]
    public class AddTwoNumbersTest : UnitTestBase
    {
        [TestMethod]
        public void AddTwoNumbersTestMethod1()
        {
            AddTwoNumbers nums = new AddTwoNumbers();
            ListNode res = nums.Execute(base.GetListNode(new int[] { 9, 9, 9 }), base.GetListNode(new int[] { 9, 9, 9 }));
            Assert.IsNotNull(res);
            Assert.IsTrue(res.Equals(base.GetListNode(new int[] { 8, 9, 9, 1 })));
        }

        [TestMethod]
        public void AddTwoNumbersTestMethod2()
        {
            AddTwoNumbers nums = new AddTwoNumbers();
            ListNode res = nums.Execute(base.GetListNode(new int[] { 9 }), base.GetListNode(new int[] { 9 }));
            Assert.IsNotNull(res);
            Assert.IsTrue(res.Equals(base.GetListNode(new int[] { 8, 1 })));
        }
    }
}
