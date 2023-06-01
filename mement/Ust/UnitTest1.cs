using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using mement;

namespace Ust
{
    [TestClass]
    public class UnitTest1
    {
        Battel cc = new mement.Battel();
        [TestMethod]
        public void TestMethod1()
        {
            string n = "グー";
            Assert.AreEqual(cc.Jan(1), n);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string n = "チョキ";
            Assert.AreEqual(cc.Jan(2), n);
        }
    }
}
