using System;

namespace Calculator.OneArgument
{
    public class Logarithm : IOneArgumentCalculator
    {
        public double Calculate2(double firstArgument)
        {
            return Math.Log10(firstArgument);
        }
    }
}
