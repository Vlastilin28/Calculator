using System;

namespace Calculator.OneArgument
{
    public class DivisionOnOne : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument == 0)
            {
                throw new Exception("Делитель равен 0");
            }
            return 1 / firstArgument;
        }
    }
}
