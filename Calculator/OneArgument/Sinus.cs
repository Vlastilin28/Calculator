using System;

namespace Calculator.OneArgument
{
    public class Sinus : IOneArgumentCalculator
    {
        public double Calculate2(double firstArgument)
        {
             return Math.Round(Math.Sin(firstArgument));
        }
    }
}
