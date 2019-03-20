using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace GreeterConsole
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

        public void Run()
        {
            var fixture = Activator.CreateInstance(_type);
            _tests.ForEach(test => test.Invoke(fixture, null));
        }
    }
}