using System;
using AirUnit.Assertions;

namespace GreeterConsole
{
    public class CalculatorTest
    {
        public void AssertThat5Plus5Equals10()
        {
            var calculator = new Calculator();
            var sum = calculator.Add(5, 5);
            Assert.Equals(10, sum);
        }
    }
}