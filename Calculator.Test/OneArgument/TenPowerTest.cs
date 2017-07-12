using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{
    [TestFixture]
    public class TenPowerTest
    {
        [TestCase(2, 100)]
        [TestCase(3, 1000)]
        [TestCase(4, 10000)]
        public void CalculatorTest(double firstValue, double expected)
        {
            var calculator = new TenPower();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
