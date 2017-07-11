using System;

namespace Calculator
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
                default:
                    throw new Exception("Warning");
            }
        }
    }
}
