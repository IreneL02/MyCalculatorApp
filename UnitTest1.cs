using Xunit;
using MyCalculatorApp;
using System.Reflection;

namespace MyCalculatorApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Sum_TwoNumbers_ReturnsCorrectResult()
        {
            Calculator calc = new Calculator();

            int result = calc.Sum(2, 3);

            Assert.Equal(5, result);
        }
    }
}