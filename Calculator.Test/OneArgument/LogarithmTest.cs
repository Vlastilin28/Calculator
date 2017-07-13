using System;
using NUnit.Framework;
using Calculator.OneArgument;

namespace Calculator.Test.OneArgument
{
    [TestFixture]
    public class LogarithmTest
    {
        [TestCase(10, 1)]
        [TestCase(100, 2)]
        [TestCase(1000, 3)]
        public void CalculatorTest(double firstValue, double expected)
        {
            var calculator = new Logarithm();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
        [Test]
        public void ErrorTest()
        {
            var calculator = new Logarithm();
            Assert.Throws<Exception>(() => calculator.Calculate(0));
        }
    }
}
