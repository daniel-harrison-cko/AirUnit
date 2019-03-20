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
                var assembly = typeof(GreeterTest).Assembly;
                var discoverer = new Discoverer();
                var fixtures = discoverer.Discover(assembly);
                
                foreach (var fixture in fixtures)
                {
                    fixture.Run();
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
