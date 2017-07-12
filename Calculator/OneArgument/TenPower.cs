using System;

namespace Calculator.OneArgument
{
    public class TenPower : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(10,firstArgument);
        }
    }
}
