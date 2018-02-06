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
    public class JewelsInStonesTest
    {
        [TestMethod]
        public void NumJewelsInStonesTestMethod1()
        {
            JewelsAndStones js = new JewelsAndStones();
            int result = js.NumJewelsInStones("aAbB", "aaaaabB");
            Assert.AreEqual(result, 7);
        }
    }
}
