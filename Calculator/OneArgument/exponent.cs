using System;

namespace Calculator.OneArgument
{
    public class Exponent : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(2, firstArgument);
        }
    }
}
