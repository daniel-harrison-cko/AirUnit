using System;
using System.Reflection;

namespace AirUnit.TestRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.LoadFile(args[0]);
            var discoverer = new Discoverer();
            var fixtures = discoverer.Discover(assembly);
            
            foreach (var fixture in fixtures)
            {
                fixture.Run();
            }
        }
    }
}
