using NUnit.Framework;
using Calculator.OneArgument;

namespace Calculator.Test.OneArgument
{
    [TestFixture]
    public class ExponetTest
    {
        [TestCase(2, 4)]
        [TestCase(3, 8)]
        [TestCase(4, 16)]
        public void CalculatorTest(double firstValue, double expected)
        {
            var calculator = new Exponent();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
