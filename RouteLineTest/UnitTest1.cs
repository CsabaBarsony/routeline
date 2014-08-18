using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RouteLineUI.Csati;

namespace RouteLineTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Csati cs = new Csati();

            Assert.AreEqual(cs.sayMyName(), "majom");
        }
    }
}
