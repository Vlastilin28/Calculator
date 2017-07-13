using System;
using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{
    public class TwoArgumentFactoryTest
    {
        [TestCase("button_plus", typeof(Addtion))]
        [TestCase("button_minus", typeof(Subtraction))]
        [TestCase("button_multiply", typeof(Multiplication))]

        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }
    }
}
