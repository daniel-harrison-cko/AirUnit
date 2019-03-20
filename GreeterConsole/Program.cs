﻿using System;
using System.Linq;

namespace GreeterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Contains("--test"))
            {
                var greeterTestFixture = Activator.CreateInstance<GreeterTest>();
                var greeterTestMethods = typeof(GreeterTest).GetMethods()
                    .Where(method => method.Name.StartsWith("Assert"))
                    .ToList();
                greeterTestMethods.ForEach(method => method.Invoke(greeterTestFixture, null));
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
