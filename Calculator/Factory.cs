using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string calcname)
        {
            switch (calcname)
            {
                case "button_plus":
                    return new Addtion();
                case "button_minus":
                    return new subtraction();
                case "button_multiply":
                    return new Multiplication();
                case "button_divide":
                    return new Division();
                default:
                    throw new Exception("Warning");
            }
        }
    }
    
}
