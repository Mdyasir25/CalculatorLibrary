using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    [TestClass]
    public class CalculatorTest
    {
        private readonly Calculator _calculator;
        public CalculatorTest()
        {
            _calculator = new Calculator();
        }
        [TestMethod]
        public void CalculatorAddTest()
        {
            var res = _calculator.CalculatorAdd(5, 4);
            Assert.AreEqual(9, res);
        }
        [TestMethod]
        public void CalculatorSubtractTest()
        {
            var res = _calculator.CalculatorSubtract(5, 4);
            Assert.AreEqual(1, res);
        }
        [TestMethod]
        public void CalculatorMultiplyTest()
        {
            var res = _calculator.CalculatorMultiply(5, 4);
            Assert.AreEqual(20, res);
        }
        [TestMethod]
        public void CalculatorDivideTest()
        {
            var res = _calculator.CalculatorDivide(8, 4);
            Assert.AreEqual(2, res);
        }
    }
}
