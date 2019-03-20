using System;
using AirUnit.Assertions;
namespace AirUnit.TestRunner.UnitTests
{
    class FixtureTest
    {
        public void AssertThatSuccessfulTestCallsPassOutput()
        {
            var fixture = new Fixture(typeof(Sample));
            fixture.AddTest(typeof(Sample).GetMethod(nameof(Sample.AssertAlwaysPasses)));
            var mockOutput = new MockOutput();
            fixture.Run(mockOutput);
            Assert.True(mockOutput.IsPassCalled);
        }

        public void AssertThatFailedTestCallsFailOutput()
        {
            var fixture = new Fixture(typeof(Sample));
            fixture.AddTest(typeof(Sample).GetMethod(nameof(Sample.AssertAlwaysFails)));
            var mockOutput = new MockOutput();
            fixture.Run(mockOutput);
            Assert.True(mockOutput.IsFailCalled);
        }

        class MockOutput : IOutput
        {
            public void Pass(string fixtureName, string testName)
            {
                IsPassCalled = true;
            }

            public void Fail(string fixtureName, string testName, string exception)
            {
                IsFailCalled = true;
            }

            public bool IsPassCalled { get; private set; } = false;
            public bool IsFailCalled { get; private set; } = false;
        }

        class Sample
        {
            public void AssertAlwaysPasses()
            {
                // Pass
            }

            public void AssertAlwaysFails()
            {
                throw new Exception("Fail!!");
            }
        }
    }
}