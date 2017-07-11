namespace Calculator.TwoArgument
{
    public class Average : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument + secondArgument) / 2;
        }
    }
}
