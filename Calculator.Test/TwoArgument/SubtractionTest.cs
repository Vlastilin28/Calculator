<<<<<<< HEAD
﻿using Calculator.TwoArgument;
=======
﻿
using Calculator.TwoArgument;
>>>>>>> bea75ee5e2115f65ed3e026f521a38a4c2d49c75
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{
    [TestFixture]
    public class SubtractionTest
    {
<<<<<<< HEAD
        [TestCase(2, 5, -3)]
        [TestCase(3, 4, -1)]
        [TestCase(-7, -2, -5)]
        public void CalculatorTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Subtraction();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
=======
        [Test]
        public void CalculatorTest()
        {
            ITwoArgumentsCalculator Calculator = new Subtraction();
            double result = Calculator.Calculate(4, 2);
            Assert.AreEqual(2, result);
>>>>>>> bea75ee5e2115f65ed3e026f521a38a4c2d49c75
        }
    }
}
