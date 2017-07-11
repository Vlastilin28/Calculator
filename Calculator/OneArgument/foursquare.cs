using System;

namespace Calculator.OneArgument
{
    public class Foursquare : IOneArgumentCalculator
    {
        public double Calculate2(double firstArgument)
        {
            return Math.Pow(firstArgument,2);
        }
    }
}
