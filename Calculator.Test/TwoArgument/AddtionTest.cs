using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{
    [TestFixture]
    public class AddtionTest
    {
        [Test]
        public void CalculatorTest()
        {
            ITwoArgumentsCalculator Calculator = new Addtion();
            double result = Calculator.Calculate(1,2);
            Assert.AreEqual(3, result);
        }
    }
}
