using System;
using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{
    public class TwoArgumentCalculatorTest
    {
        [TestCase("Average", typeof(Average))]
        [TestCase("button_divide", typeof(Division))]
        [TestCase("button_plus", typeof(Addtion))]

        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
