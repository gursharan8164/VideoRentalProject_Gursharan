using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoRentalProject_Gursharan;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            UnitTestCase customLogic = new UnitTestCase();
            var result = customLogic.AddTwoPostiveNumber(10, 20);
            Assert.IsTrue(result == 30);
        }
        [TestMethod()]
        public void CheckDbConnConfig()
        {
          
        }
    }
}

