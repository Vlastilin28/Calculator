using System;

namespace Calculator.OneArgument
{
    public class Logarithm : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument == 0)
            {
                throw new Exception("Число не должно равняться 0");
            }
            return Math.Log10(firstArgument);
        }
    }
}
