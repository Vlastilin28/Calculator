using System;
using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.OneArgument
{

    namespace Calculator.Test.OneArgument
    {
        [TestFixture]
        public class DivisionOnOneTest
        {
            [TestCase(1, 1)]
            [TestCase(2, 0.5)]
            [TestCase(4, 0.25)]
            public void CalculatorTest(double firstValue, double expected)
            {
                var calculator = new DivisionOnOne();
                var actualResult = calculator.Calculate(firstValue);
                Assert.AreEqual(expected, actualResult);
            }
            [Test]
            public void ErrorTest()
            {
                var calculator = new Division();
                Assert.Throws<Exception>(() => calculator.Calculate(1,0));
            }
        }
    }
}
