using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{
    [TestFixture]
    public class DivisionTest
    {
<<<<<<< HEAD
        [TestCase(6, 3, 2)]
        [TestCase(4, 1, 4)]
        [TestCase(24, 8, 3)]
        public void CalculatorTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Division();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
=======
        [Test]
        public void CalculatorTest()
        {
            ITwoArgumentsCalculator Calculator = new Division();
            double result = Calculator.Calculate(9, 3);
            Assert.AreEqual(3, result);
>>>>>>> bea75ee5e2115f65ed3e026f521a38a4c2d49c75
        }
    }
}
