using NUnit.Framework;
using Calculator.OneArgument;

namespace Calculator.Test.OneArgument
{
    [TestFixture]
    public class FourSquareTest
    {
        [TestCase(2, 4)]
        [TestCase(6, 36)]
        [TestCase(8, 64)]
        public void CalculatorTest(double firstValue, double expected)
        {
            var calculator = new Foursquare();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
