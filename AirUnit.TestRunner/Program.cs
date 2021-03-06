﻿using System;
using System.Reflection;

namespace AirUnit.TestRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.LoadFrom(args[0]);
            var discoverer = new Discoverer();
            var fixtures = discoverer.Discover(assembly);
            
            foreach (var fixture in fixtures)
            {
                fixture.Run(new ConsoleOutput());
            }
        }
    }
}
