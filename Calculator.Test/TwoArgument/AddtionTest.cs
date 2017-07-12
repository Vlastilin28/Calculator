using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{
    [TestFixture]
    public class AddtionTest
    {
<<<<<<< HEAD
        [TestCase(2, 5, 7)]
        [TestCase(3, 4, 7)]
        [TestCase(-7, -2, -9)]
        public void CalculatorTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Addtion();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
=======
        [Test]
        public void CalculatorTest()
        {
            ITwoArgumentsCalculator Calculator = new Addtion();
            double result = Calculator.Calculate(1,2);
            Assert.AreEqual(3, result);
>>>>>>> bea75ee5e2115f65ed3e026f521a38a4c2d49c75
        }
    }
}
