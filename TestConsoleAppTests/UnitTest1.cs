using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestConsoleApp.Util;

namespace TestConsoleAppTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            CalculatorUtil calculatorUtil = new CalculatorUtil();
            int res = calculatorUtil.Add(5, 7);
            Assert.AreEqual(12, res);
        }
    }
}
