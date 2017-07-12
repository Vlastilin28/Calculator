using NUnit.Framework;
<<<<<<< HEAD
=======
using Calculator;
>>>>>>> bea75ee5e2115f65ed3e026f521a38a4c2d49c75
using Calculator.OneArgument;

namespace Calculator.Test.OneArgument
{
    [TestFixture]
    public class CosinusTest
    {
<<<<<<< HEAD
        [TestCase(90, 0)]
        [TestCase(0, 1)]
        [TestCase(180,-1)]
        public void CalculatorTest(double firstValue, double expected)
        {
            var calculator = new Cosinus();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
=======
        [Test]
        public void CalculatorTest()
        {
            IOneArgumentCalculator Calculator = new Cosinus();
            double result = Calculator.Calculate(0);
            Assert.AreEqual(1, result);
>>>>>>> bea75ee5e2115f65ed3e026f521a38a4c2d49c75
        }
    }
}
