using NUnit.Framework;
using Calculator.OneArgument;

namespace Calculator.Test.OneArgument
{
    [TestFixture]
    public class CosinusTest
    {
        [TestCase(90, 0)]
        [TestCase(0, 1)]
        [TestCase(180,-1)]
        public void CalculatorTest(double firstValue, double expected)
        {
            var calculator = new Cosinus();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
