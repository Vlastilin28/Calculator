using NUnit.Framework;
using Calculator;
using Calculator.OneArgument;

namespace Calculator.Test.OneArgument
{
    [TestFixture]
    public class CosinusTest
    {
        [Test]
        public void CalculatorTest()
        {
            IOneArgumentCalculator Calculator = new Cosinus();
            double result = Calculator.Calculate(0);
            Assert.AreEqual(1, result);
        }
    }
}
