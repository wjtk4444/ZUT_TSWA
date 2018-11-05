using CalculatorLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
