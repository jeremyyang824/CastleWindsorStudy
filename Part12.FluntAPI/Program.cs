using System;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace Part12.FluntAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            container.Register(
                Component.For<Main>().LifestyleTransient(), //Singleton is the default lifestyle
                Component.For<IDependency1>().ImplementedBy<Dependency1>().LifestyleTransient(),
                Component.For<IDependency2>().ImplementedBy<Dependency2>().LifestyleTransient()
            );

            var mainThing = container.Resolve<Main>();
            mainThing.DoSomething();
            Console.WriteLine("Obj1：{0}\r\nObj2：{1}", mainThing.Object1, mainThing.Object2);

            Console.ReadKey();
        }
    }
}
