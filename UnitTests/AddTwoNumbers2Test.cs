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
    public class AddTwoNumbers2Test : UnitTestBase
    {
        [TestMethod]
        public void AddTwoNumbers2TestMethod1()
        {
            AddTwoNumbers2 nums = new AddTwoNumbers2();
            ListNode res = nums.AddTwoNumbers(base.GetListNode(new int[] { 9, 9, 9, 9 }), base.GetListNode(new int[] { 9, 9, 9 }));
            Assert.IsNotNull(res);
            Assert.IsTrue(res.Equals(base.GetListNode(new int[] { 1, 0, 9, 9, 8 })));
        }
    }
}
