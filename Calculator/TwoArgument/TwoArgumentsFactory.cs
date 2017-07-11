using System;

namespace Calculator.TwoArgument
{
    public static class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "button_plus":
                    return new Addtion();
                case "button_minus":
                    return new Subtraction();
                case "button_multiply":
                    return new Multiplication();
                case "button_divide":
                    return new Division();
                case "xToPower":
                    return new xToPower();
                case "xTo1mY":
                    return new XToPowerOfInverseY();
                case "Average":
                    return new Average();
                default:
                    throw new Exception("Warning");
            }
        }
    }
}
