using System;
using System.Linq;

namespace GreeterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Contains("--test"))
            {
                var fixtureTypes = typeof(GreeterTest).Assembly
                    .GetTypes().Where(type => type.Name.EndsWith("Test"));

                foreach (var fixtureType in fixtureTypes)
                {
                    var fixture = Activator.CreateInstance(fixtureType);
                    var methods = fixtureType.GetMethods();

                    foreach (var method in methods)
                    {
                        if (method.Name.StartsWith("Assert"))
                        {
                            method.Invoke(fixture, null);
                        }
                    }
                }
            }
            else
            {
                var greeter = new Greeter();
                var greeting = greeter.Greet("Daniel", DateTime.Now.Hour);
                Console.WriteLine(greeting);
            }
        }
    }
}
