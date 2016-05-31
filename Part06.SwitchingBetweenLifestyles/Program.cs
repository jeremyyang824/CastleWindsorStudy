using System;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;

namespace Part06.SwitchingBetweenLifestyles
{
    class Program
    {
        static void Main(string[] args)
        {
            WindsorContainer container = new WindsorContainer(new XmlInterpreter());

            AddingService sheepCounted = container.Resolve<AddingService>();
            AddingService catsHerded = container.Resolve<AddingService>();

            sheepCounted.AddAmmount(10);
            sheepCounted.AddAmmount(50);

            catsHerded.AddAmmount(3);
            catsHerded.AddAmmount(12);

            Console.WriteLine("You have counted {0} sheep and herded {1} angry cats", sheepCounted.Total, catsHerded.Total);

            Console.Read();
        }
    }
}
