using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public decimal Calculate(string operation)
        {
            decimal result = 0;
            String[] op = operation.Split('+');
            foreach (string t in op)
            {
                result += decimal.Parse(t);
            }
            return result;
        }
    }
}