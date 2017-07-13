using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Test.OneArgument
{
    public class OneArgumentFactoryTest
    {
        [TestCase("Sinus", typeof(Sinus))]
        [TestCase("Logarithm", typeof(Logarithm))]
        [TestCase("exponent", typeof(Exponent))]

        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }
    }
}
