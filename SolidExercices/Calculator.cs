using System;
using System.Collections.Generic;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        private List<decimal> _numbers = new List<decimal>();

        public decimal Calculate(string operation)
        {
            var operateurs = new Dictionary<char, Func<decimal, decimal, decimal>>()
            {
                {'+', Addition},
                {'-', Soustraction},
                {'x', Multiplication},
                {'/', Division}
            };
            decimal result = 0;

            foreach (var item in operateurs)
            {
                if (operation.IndexOf(item.Key) != -1)
                {
                    String[] op = operation.Split(item.Key);
                    foreach (string t in op)
                    {
                        result = item.Value(result,decimal.Parse(t));
                    }

                    return result;
                }
            }
            return result;
        }

        decimal Addition(decimal a, decimal b)
        {
            return a + b;
        }

        decimal Soustraction(decimal a, decimal b)
        {
            return a - b;
        }

        decimal Multiplication(decimal a, decimal b)
        {
            return a * b;
        }

        decimal Division(decimal a, decimal b)
        {
            return a / b;
        }
    }
}