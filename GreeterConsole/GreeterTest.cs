using System;

namespace GreeterConsole
{
    public class GreeterTest
    {
        private readonly Greeter _greeter = new Greeter();

        public void Run()
        {
            AssertThatGreetingContainsHelloIfHourIsNotProvided();
            AssertThatGreetingContainsGoodMorningIfHourIsLessThan12();
            AssertThatGreetingContainsGoodAfternoonIfHourIsGreaterThanOrEqualTo12();
            AssertThatGreetingContainsName();
        }

        private void AssertThatGreetingContainsHelloIfHourIsNotProvided()
        {
            var greeting = _greeter.Greet("Daniel");
            if (!greeting.Contains("Hello"))
                throw new Exception($"Expected {greeting} to contain Hello");
        }

        private void AssertThatGreetingContainsGoodMorningIfHourIsLessThan12()
        {
            var greeting = _greeter.Greet("Daniel", hour: 11);
            if (!greeting.Contains("Good morning"))
                throw new Exception($"Expected {greeting} to contain Good morning");
        }

        private void AssertThatGreetingContainsGoodAfternoonIfHourIsGreaterThanOrEqualTo12()
        {
            var greeting = _greeter.Greet("Daniel", hour: 12);
            if (!greeting.Contains("Good afternoon"))
                throw new Exception($"Expected {greeting} to contain Good afternoon");
        }

        private void AssertThatGreetingContainsName()
        {
            var greeting = _greeter.Greet("Daniel");
            if (!greeting.Contains("Daniel"))
                throw new Exception($"Expected {greeting} to contain Daniel");
        }
    }
}