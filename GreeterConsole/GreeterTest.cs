using System;

namespace GreeterConsole
{
    public class GreeterTest
    {
        private readonly Greeter _greeter = new Greeter();

        public void AssertThatGreetingContainsHelloIfHourIsNotProvided()
        {
            var greeting = _greeter.Greet("Daniel");
            if (!greeting.Contains("Hello"))
                throw new Exception($"Expected {greeting} to contain Hello");
        }

        public void AssertThatGreetingContainsGoodMorningIfHourIsLessThan12()
        {
            var greeting = _greeter.Greet("Daniel", hour: 11);
            if (!greeting.Contains("Good morning"))
                throw new Exception($"Expected {greeting} to contain Good morning");
        }

        public void AssertThatGreetingContainsGoodAfternoonIfHourIsGreaterThanOrEqualTo12()
        {
            var greeting = _greeter.Greet("Daniel", hour: 12);
            if (!greeting.Contains("Good afternoon"))
                throw new Exception($"Expected {greeting} to contain Good afternoon");
        }

        public void AssertThatGreetingContainsName()
        {
            var greeting = _greeter.Greet("Daniel");
            if (!greeting.Contains("Daniel"))
                throw new Exception($"Expected {greeting} to contain Daniel");
        }
    }
}