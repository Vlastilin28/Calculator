﻿namespace Calculator.TwoArguments
{
    public class Multiplication:ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    }
}
