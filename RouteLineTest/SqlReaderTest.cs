using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RouteLineUI.Classes;

namespace RouteLineTest
{
    [TestClass]
    public class SqlReaderTest
    {
        [TestMethod]
        public void substituteQuery()
        {
            Assert.AreEqual("egy kettő és három", SqlReader.substituteQuery("egy $var2 és $var3", "var2=kettő;var3=három"));
            Assert.AreEqual("egy kettő és három", SqlReader.substituteQuery("egy $var2 és $var3 ", "var2=kettő;var3=három"));
            Assert.AreEqual("egy kettő és három és", SqlReader.substituteQuery("egy $var2 és $var3 és", "var2=kettő;var3=három"));
            Assert.AreEqual("egy kettő és három és", SqlReader.substituteQuery("egy $var2 és $var3 és ", "var2=kettő;var3=három"));
            Assert.AreEqual("egy kettő és három és", SqlReader.substituteQuery("egy kettő és három és", "var2=kettő;var3=három"));
        }

        [TestMethod]
        public void getVariableValue()
        {
            Assert.AreEqual("egy", SqlReader.getVariableValue("var1=egy", "var1"));
            Assert.AreEqual("egy", SqlReader.getVariableValue("var1=egy;var2=kettő", "var1"));
            Assert.AreEqual("kettő", SqlReader.getVariableValue("var1=egy;var2=kettő", "var2"));
        }
    }
}
