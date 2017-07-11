using System;

namespace Calculator.OneArgument
{
    public class Cosinus : IOneArgumentCalculator
    {
        public double Calculate2(double firstArgument)
        {
            return Math.Round(Math.Cos(firstArgument));
        }
    }
}
