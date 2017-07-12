using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{
    [TestFixture]
    public class XToPowerOfInverseYTest
    {
        [TestCase(2, 1, 2)]
        [TestCase(6, 1, 6)]
        [TestCase(7, 1, 7)]
        public void CalculatorTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new XToPowerOfInverseY();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
