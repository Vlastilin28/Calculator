using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{
    [TestFixture]
    public class MultiplicationTest
    {
        [TestCase(2, 5, 10)]
        [TestCase(3, 4, 12)]
        [TestCase(-7, -2, 14)]
        public void CalculatorTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Multiplication();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
