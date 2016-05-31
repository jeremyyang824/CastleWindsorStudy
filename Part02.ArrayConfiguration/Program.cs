using System;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;

namespace Part02.ArrayConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            WindsorContainer container = new WindsorContainer(new XmlInterpreter());

            HolidayService holidayService = container.Resolve<HolidayService>();

            DateTime xmas = new DateTime(2007, 12, 25);
            DateTime newYears = new DateTime(2008, 1, 2);

            Console.WriteLine(holidayService.IsHoliday(xmas) ? "merry xmas!" : "xmas is only for management!");

            Console.WriteLine(holidayService.IsHoliday(newYears)
                ? "happy new year"
                : "new year, you haven't done all the work for last year!");

            Console.Read();
        }
    }
}
