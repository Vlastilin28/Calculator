using System;

namespace Calculator.TwoArgument
{
    public class xToPower : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            
            return Math.Pow(firstArgument , secondArgument);
        }
    }
}
