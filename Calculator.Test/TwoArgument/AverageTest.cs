using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{
    [TestFixture]
    public class AverageTest
    {
        [TestCase(2, 2, 2)]
        [TestCase(4, 4, 4)]
        [TestCase(8, 6, 7)]
        public void CalculatorTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Average();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
