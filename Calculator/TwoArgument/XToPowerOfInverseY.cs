using System;

namespace Calculator.TwoArgument
{
    public class XToPowerOfInverseY : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, 1 / secondArgument);
        }
    }


}
