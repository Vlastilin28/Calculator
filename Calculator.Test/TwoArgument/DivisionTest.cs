using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{
    [TestFixture]
    public class DivisionTest
    {
        [TestCase(6, 3, 2)]
        [TestCase(4, 1, 4)]
        [TestCase(24, 8, 3)]
        public void CalculatorTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Division();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
