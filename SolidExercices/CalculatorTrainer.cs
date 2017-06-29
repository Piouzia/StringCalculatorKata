using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    public class CalculatorTrainer
    {
        private readonly OperationGenerator _operations;

        public CalculatorTrainer(OperationGenerator op)
        {
            _operations = op;
        }

        public void Run()
        {
            var calculator = new Calculator(new Operators());
            foreach (var operation in _operations.Operations)
            {
                try
                {
                    var result = calculator.Calculate(operation);
                    Console.WriteLine(operation + " = " + result);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
            }
            Console.ReadKey();
        }
    }
}