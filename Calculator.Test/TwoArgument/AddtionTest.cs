using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{
    [TestFixture]
    public class AddtionTest
    {
        [TestCase(6, 3, 9)]
        [TestCase(4, 1, 5)]
        [TestCase(24, 8, 32)]
        public void CalculatorTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Addtion();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
