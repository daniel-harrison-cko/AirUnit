using System;
using AirUnit.Assertions;

namespace GreeterConsole
{
    public class GreeterTest
    {
        private readonly Greeter _greeter = new Greeter();

        public void AssertThatGreetingContainsHelloIfHourIsNotProvided()
        {
            var greeting = _greeter.Greet("Daniel");
            Assert.Contains("Hello", greeting);
        }

        public void AssertThatGreetingContainsGoodMorningIfHourIsLessThan12()
        {
            var greeting = _greeter.Greet("Daniel", hour: 11);
            Assert.Contains("Good morning", greeting);
        }

        public void AssertThatGreetingContainsGoodAfternoonIfHourIsGreaterThanOrEqualTo12()
        {
            var greeting = _greeter.Greet("Daniel", hour: 12);
            Assert.Contains("Good afternoon", greeting);
        }

        public void AssertThatGreetingContainsName()
        {
            var greeting = _greeter.Greet("Daniel");
            Assert.Contains("Daniel", greeting);
        }
    }
}