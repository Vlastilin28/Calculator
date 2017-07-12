using System;

namespace Calculator.OneArgument
{
    public class Sinus : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
             return Math.Round(Math.Sin(firstArgument));
        }
    }
}
