using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{
    [TestFixture]
    public class SubtractionTest
    {
        [TestCase(2, 5, -3)]
        [TestCase(3, 4, -1)]
        [TestCase(-7, -2, -5)]
        public void CalculatorTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Subtraction();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}