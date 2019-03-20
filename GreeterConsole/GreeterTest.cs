using System;

namespace GreeterConsole
{
    public class GreeterTest
    {
        public void Run()
        {
            AssertThatGreetingContainsHello();
            AssertThatGreetingContainsName();
        }

        private void AssertThatGreetingContainsHello()
        {
            var greeter = new Greeter();
            var greeting = greeter.Greet("Daniel");
            if (!greeting.Contains("Hello"))
                throw new Exception($"Expected {greeting} to contain Hello");
        }

        private void AssertThatGreetingContainsName()
        {
            var greeter = new Greeter();
            var greeting = greeter.Greet("Daniel");
            if (!greeting.Contains("Daniel"))
                throw new Exception($"Expected {greeting} to contain Daniel");
        }
    }
}