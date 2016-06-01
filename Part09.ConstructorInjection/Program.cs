using System;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;

namespace Part09.ConstructorInjection
{
    public class Program
    {
        static void Main(string[] args)
        {
            WindsorContainer container = new WindsorContainer(new XmlInterpreter());

            SecretMessageSender sender = container.Resolve<SecretMessageSender>();

            sender.SendMessage("hammet", "castle is great!");

            Console.Read();
        }
    }
}
