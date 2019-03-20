using System;

namespace GreeterConsole
{
    class Greeter
    {
        public string Greet(string name)
        {
            return $"Hello, {name}!";
        }

        public string Greet(string name, int hour)
        {
            if (hour < 12)
                return $"Good morning, {name}!";
            else if (hour >= 12)
                return $"Good afternoon, {name}!";
            
            return Greet(name);
        }
    }
}