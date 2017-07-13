using System;
using System.Windows.Forms;

namespace Calculator.TwoArgument
{
    public class Division : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Делитель равен 0");
            }
                return firstArgument / secondArgument;
        }
    }
}
