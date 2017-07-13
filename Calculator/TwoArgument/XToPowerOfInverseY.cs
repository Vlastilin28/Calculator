using System;

namespace Calculator.TwoArgument
{
    public class XToPowerOfInverseY : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Делитель равен 0");
            }
            return Math.Pow(firstArgument, 1 / secondArgument);
        }
    }


}
