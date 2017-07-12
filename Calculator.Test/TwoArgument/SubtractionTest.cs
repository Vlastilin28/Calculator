
using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{
    [TestFixture]
    public class SubtractionTest
    {
        [Test]
        public void CalculatorTest()
        {
            ITwoArgumentsCalculator Calculator = new Subtraction();
            double result = Calculator.Calculate(4, 2);
            Assert.AreEqual(2, result);
        }
    }
}
