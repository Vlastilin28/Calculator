﻿namespace Calculator.TwoArgument
{
    public class Subtraction : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    }
}
