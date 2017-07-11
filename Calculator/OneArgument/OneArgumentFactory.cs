using System;

namespace Calculator.OneArgument
{
    public static class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator2(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Sinus":
                    return new Sinus();
                case "Logarithm":
                    return new Logarithm();
                case "exponent":
                    return new Exponent();
                case "foursquare":
                    return new Foursquare();
                default:
                    throw new Exception("Warning");
            }
        }
    }
}
