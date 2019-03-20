using System;

namespace AirUnit.TestRunner
{
    class ConsoleOutput : IOutput
    {
        public void Pass(string fixtureName, string testName)
        {
            Console.WriteLine($"PASS: {fixtureName}.{testName}");
        }

        public void Fail(string fixtureName, string testName, string exception)
        {
            Console.WriteLine($"FAIL: {fixtureName}.{testName}");
            Console.WriteLine(exception);
        }
    }
}