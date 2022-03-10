using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestConsoleApp.Util;

namespace TestConsoleAppTest
{
    [TestClass]
    public class CalculatorUtilTest
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