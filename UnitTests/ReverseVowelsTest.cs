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
    public class ReverseVowelsTest
    {
        [TestMethod]
        public void ReverseVowelsTestMethod1()
        {
            ReverseVowels rv = new ReverseVowels();
            rv.Execute("leetcode");
        }
    }
}
