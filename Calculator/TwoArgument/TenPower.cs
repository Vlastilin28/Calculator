using System;
using Calculator.OneArgument;

namespace Calculator.TwoArgument
{
    public class TenPower : IOneArgumentCalculator
    {
        public double Calculate2(double firstArgument)
        {
            return Math.Pow(10,firstArgument);
        }
    }
}
