using System;
using Calculator.OneArgument;

namespace Calculator.TwoArgument
{
    public class TenPower : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(10,firstArgument);
        }
    }
}
