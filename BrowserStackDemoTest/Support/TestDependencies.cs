using System;
using System.Linq;

using Autofac;
using SpecFlow.Autofac;
using TechTalk.SpecFlow;

namespace BrowserStackDemoTest.Support
{
    public static class TestDependencies
    {
        [ScenarioDependencies]
        public static ContainerBuilder CreateContainerBuilder()
        {
            // create container with the runtime dependencies
            var builder = new ContainerBuilder();

            // Both registration variants now quit chrome driver correctly.
            builder.RegisterType<BrowserDriver>().AsSelf().SingleInstance();
            //builder.RegisterType<BrowserDriver>().AsSelf().InstancePerLifetimeScope();

            builder.RegisterType<TestContext>().AsSelf().InstancePerLifetimeScope();

            builder.RegisterTypes(
                typeof(TestDependencies).Assembly.GetTypes().
                    Where(t => Attribute.IsDefined(t, typeof(BindingAttribute))).ToArray()).
                InstancePerLifetimeScope();

            return builder;
        }
    }
}
