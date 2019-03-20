namespace AirUnit.TestRunner
{
    public interface IOutput
    {
        void Pass(string fixtureName, string testName);
        void Fail(string fixtureName, string testName, string exception);
    }
}