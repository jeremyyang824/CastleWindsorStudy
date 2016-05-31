using System;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;

namespace Part07.SwitchingImplementations
{
    class Program
    {
        static void Main(string[] args)
        {
            WindsorContainer container = new WindsorContainer(new XmlInterpreter());

            IMessageOfTheDay motd = container.Resolve<IMessageOfTheDay>();

            Console.WriteLine("MOTD: {0}", motd.GetMessageOfTheDay());

            Console.Read();
        }
    }
}
