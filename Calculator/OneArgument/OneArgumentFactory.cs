using System;
using Calculator.TwoArgument;

namespace Calculator.OneArgument
{
    public static class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string calculatorName)
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
                case "Cosinus":
                    return new Cosinus();
                case "DivisionOnOne":
                    return new DivisionOnOne();
                case "TenPower":
                    return new TenPower();
                default:
                    throw new Exception("Warning");
            }
        }
    }
}
