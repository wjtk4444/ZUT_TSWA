using CalculatorLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass]
    public class LogicTests
    {
        [TestMethod]
        public void InitialValuesTest()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(0, calculator.result);
        }
    }
}
