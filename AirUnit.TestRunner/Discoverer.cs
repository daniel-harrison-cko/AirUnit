using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AirUnit.TestRunner
{
    class Discoverer
    {
        public IEnumerable<Fixture> Discover(Assembly assembly)
        {
            foreach (var fixtureType in FixtureTypes(assembly))
            {
                var fixture = new Fixture(fixtureType);

                foreach (var method in TestMethods(fixtureType))
                {
                    fixture.AddTest(method);
                }

                yield return fixture;
            }
        }

        private static IEnumerable<Type> FixtureTypes(Assembly assembly)
        {
            return assembly.GetTypes()
                .Where(type => type.Name.EndsWith("Test"));
        }

        private static IEnumerable<MethodInfo> TestMethods(Type type)
        {
            return type.GetMethods()
                .Where(method => method.Name.StartsWith("Assert"));
        }
    }
}