
using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{
    [TestFixture]
    public class XToPowerTest
    {
        [TestCase(2, 2, 4)]
        [TestCase(6, 2, 36)]
        [TestCase(7, 2, 49)]
        public void CalculatorTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new xToPower();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }

    }
}
