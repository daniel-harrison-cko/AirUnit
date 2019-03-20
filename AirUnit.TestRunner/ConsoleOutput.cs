using System;

namespace AirUnit.TestRunner
{
    class ConsoleOutput : IOutput
    {
        public void Pass(string fixtureName, string testName)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"PASS: {fixtureName}.{testName}");
            Console.ResetColor();
        }

        public void Fail(string fixtureName, string testName, string exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"FAIL: {fixtureName}.{testName}");
            Console.WriteLine(exception);
            Console.ResetColor();
        }
    }
}