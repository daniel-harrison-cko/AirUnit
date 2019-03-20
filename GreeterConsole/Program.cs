using System;
using System.Linq;

namespace GreeterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var greeter = new Greeter();
            var greeting = greeter.Greet("Daniel", DateTime.Now.Hour);
            Console.WriteLine(greeting);
        }
    }
}
