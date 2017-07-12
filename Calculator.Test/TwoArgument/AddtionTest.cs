using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{
    [TestFixture]
    public class AddtionTest
    {
        [TestCase(2, 5, 7)]
        [TestCase(3, 4, 7)]
        [TestCase(-7, -2, -9)]
        public void CalculatorTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Addtion();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
