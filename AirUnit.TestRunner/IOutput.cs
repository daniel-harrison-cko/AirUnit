namespace AirUnit.TestRunner
{
    interface IOutput
    {
        void Pass(string fixtureName, string testName);
        void Fail(string fixtureName, string testName, string exception);
    }
}