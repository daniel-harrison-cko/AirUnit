using System;

namespace AirUnit.Assertions
{
    public static class Assert
    {
        public static void Contains(string word, string text)
        {
            if (!text.Contains(word))
                throw new Exception($"Expected {text} to contain {word}");
        }

        public static void Equals(int expected, int actual)
        {
            if (expected != actual)
                throw new Exception($"Expected {expected} to be {actual}");
        }

        public static void True(bool test)
        {
            if (!test)
                throw new Exception($"Expected true but was false");
        }
    }
}