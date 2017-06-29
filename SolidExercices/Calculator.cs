using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        private Operators _operators;

        public Calculator(Operators operators)
        {
            this._operators = operators;
        }

        public decimal Calculate(string operation)
        {
            decimal result = 0;
            foreach (var item in _operators.Operateurs)
            {
                if (operation.Contains(item.Key))
                {
                    String[] op = operation.Split(item.Key);
                    bool firstElement = true;
                    foreach (string t in op)
                    {
                        if (firstElement)
                        {
                            try
                            {
                                result = decimal.Parse(t);;
                            }
                            catch (FormatException exFormat)
                            {
                                throw new ArgumentException("Erreur : mauvais format.");
                            }
                            
                            firstElement = false;
                        }
                        else
                        {
                            result = item.Value(result, decimal.Parse(t));
                        }
                    }
                }
            }
            return result;
        }
    }
}