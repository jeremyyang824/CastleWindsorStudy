using System;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;

namespace Part01.SimpleConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            //通过xml配置(App.config)依赖注入
            WindsorContainer container = new WindsorContainer(new XmlInterpreter());

            //TaxCalculator calculator = container.Resolve<TaxCalculator>();
            TaxCalculator calculator = container.Resolve<TaxCalculator>("taxcalc.service");

            decimal gross = 100;
            decimal tax = calculator.CalculateTax(gross);

            Console.WriteLine("Gross: {0}, Tax: {1}", gross, tax);
            Console.Read();
        }
    }
}
