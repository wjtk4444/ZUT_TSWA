using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLogic;

namespace CalculatorUnitTest
{
    [TestClass]
    public class GUITests
    {
        [TestMethod]
        public void InitialValuesTest()
        {
            Calculator calculator = new Calculator();

            Assert.AreEqual("0", calculator.displayValue);
        }
    }
}
