using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{
    [TestFixture]
    public class DivisionTest
    {
        [Test]
        public void CalculatorTest()
        {
            ITwoArgumentsCalculator Calculator = new Division();
            double result = Calculator.Calculate(9, 3);
            Assert.AreEqual(3, result);
        }
    }
}
