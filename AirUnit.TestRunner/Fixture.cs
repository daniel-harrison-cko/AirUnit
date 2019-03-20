using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace AirUnit.TestRunner
{
    class Fixture
    {
        private readonly Type _type;
        private readonly List<MethodInfo> _tests = new List<MethodInfo>();

        public Fixture(Type type)
        {
            _type = type;
        }

        public void AddTest(MethodInfo test)
        {
            _tests.Add(test);
        }

        public void Run(IOutput output)
        {
            var fixture = Activator.CreateInstance(_type);
            _tests.ForEach(test => {
                try
                {
                    test.Invoke(fixture, null);
                    output.Pass(_type.Name, test.Name);
                }
                catch (Exception e)
                {
                    output.Fail(_type.Name, test.Name, e.ToString());
                }
            });
        }
    }
}