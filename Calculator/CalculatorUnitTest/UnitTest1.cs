using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLogic;

namespace CalculatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod0()
        {
            Calculator calculator = new Calculator();
            calculator.result = 255;
            calculator.inputLength = InputLength.BYTE;
            calculator.inputMode = InputMode.BIN;

            Assert.AreEqual("11111111", calculator.displayValue);
        }
    }
}
