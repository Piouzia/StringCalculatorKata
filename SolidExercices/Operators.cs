using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    public class Operators
    {
        public Operators()
        {
            Operateurs = new Dictionary<char, Func<decimal, decimal, decimal>>()
            {
                {'+', Addition},
                {'-', Soustraction},
                {'x', Multiplication},
                {'/', Division}
            };
        }
        public Dictionary<char, Func<decimal, decimal, decimal>> Operateurs { get; set; }

        static decimal Addition(decimal a, decimal b)
        {
            return a + b;
        }

        static decimal Soustraction(decimal a, decimal b)
        {
            return a - b;
        }

        static decimal Multiplication(decimal a, decimal b)
        {
            return a * b;
        }

        static decimal Division(decimal a, decimal b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException dZero)
            {
                throw new ArgumentException("Erreur : division par zéro.");
            }
        }
    }
}
