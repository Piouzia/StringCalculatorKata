using NFluent;
using NUnit.Framework;

namespace SolidExercices.Tests
{
    public class CalculatorShould
    {
        [Test]
        public void CalculateASum()
        {
            var calculator = new Calculator(new Operators());
            var result = calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(3.3m);
        }

        public void CalculateMultipleSum()
        {
            var calculator = new Calculator(new Operators());
            var result = calculator.Calculate("1+2,3+3+0,5");
            Check.That(result).IsEqualTo(6.8m);
        }

        public void CalculateASub()
        {
            var calculator = new Calculator(new Operators());
            var result = calculator.Calculate("3-2,3");
            Check.That(result).IsEqualTo(0.7m);
        }

        public void CalculateAMul()
        {
            var calculator = new Calculator(new Operators());
            var result = calculator.Calculate("2x3");
            Check.That(result).IsEqualTo(6m);
        }

        public void CalculateADiv()
        {
            var calculator = new Calculator(new Operators());
            var result = calculator.Calculate("10/2");
            Check.That(result).IsEqualTo(5m);
        }
    }
}
