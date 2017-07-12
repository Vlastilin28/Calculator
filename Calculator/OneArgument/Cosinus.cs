using System;

namespace Calculator.OneArgument
{
    public class Cosinus : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Round(Math.Cos(firstArgument));
        }
    }
}
