namespace Calculator.TwoArgument
{
    public class Division : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument / secondArgument;
        }
    }
}
