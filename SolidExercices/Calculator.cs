using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public decimal Calculate(string operation)
        {
            char[] operateurs = { '+', '-', 'x', '/'};
            decimal result = 0;

            foreach (char c in operateurs)
            {
                if (operation.IndexOf(c) != -1)
                {
                    String[] op = operation.Split(c);
                    foreach (string t in op)
                    {
                        switch (c)
                        {
                            case '+':
                                result += decimal.Parse(t);
                                break;
                            case '-':
                                result -= decimal.Parse(t);
                                break;
                            case 'x':
                                result *= decimal.Parse(t);
                                break;
                            case '/':
                                result /= decimal.Parse(t);
                                break;
                        }
                    }
                }
            }
            return result;
        }
    }
}