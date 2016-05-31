using System;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;

namespace Part04.SwitchingConfigurations
{
    class Program
    {
        static void Main(string[] args)
        {
            WindsorContainer container = new WindsorContainer(new XmlInterpreter());

            WhatConfigurationService whatConfiguration = container.Resolve<WhatConfigurationService>();

            Console.WriteLine("Configuration: {0}", whatConfiguration.Configuration);

            Console.Read();
        }
    }
}
