namespace Calculator.OneArgument
{
    public class DivisionOnOne : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return 1 / firstArgument;
        }
    }
}
