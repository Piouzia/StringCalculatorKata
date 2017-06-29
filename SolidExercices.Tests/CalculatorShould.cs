using NFluent;
using NUnit.Framework;

namespace SolidExercices.Tests
{
    public class CalculatorShould
    {
        [Test]
        public void CalculateASum()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(3.3m);

            result = calculator.Calculate("3-2,3");
            Check.That(result).IsEqualTo(0.7m);

            result = calculator.Calculate("2x3");
            Check.That(result).IsEqualTo(6m);

            result = calculator.Calculate("10/2");
            Check.That(result).IsEqualTo(5m);
        }
    }
}
