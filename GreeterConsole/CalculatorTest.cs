using System;

namespace GreeterConsole
{
    class CalculatorTest
    {
        public void AssertThat5Plus5Equals10()
        {
            var calculator = new Calculator();
            var sum = calculator.Add(5, 5);
            if (sum != 10)
                throw new Exception($"Expected {sum} to be 10");
        }
    }
}