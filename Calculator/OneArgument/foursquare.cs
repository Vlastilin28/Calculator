using System;

namespace Calculator.OneArgument
{
    public class Foursquare : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument,2);
        }
    }
}
