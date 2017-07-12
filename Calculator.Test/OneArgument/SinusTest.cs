using NUnit.Framework;
using Calculator.OneArgument;

namespace Calculator.Test.OneArgument
{
    [TestFixture]
    public class SinusTest
    {
        [TestCase(90, 1)]
        [TestCase(0, 0)]
        [TestCase(180, -1)]
        public void CalculatorTest(double firstValue, double expected)
        {
            var calculator = new Sinus();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
