using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core;
using Castle.Facilities.Logging;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace Part13.DynamicProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            container.Register(
                Component.For<ITaskAppService>().ImplementedBy<TaskAppService>().LifestyleTransient(),
                Component.For<AbpDynamicApiControllerInterceptor<ITaskAppService>>().LifestyleTransient(),
                Component.For<DynamicApiController<ITaskAppService>>()
                        //.Proxy.AdditionalInterfaces(typeof(ITaskAppService))
                        .Interceptors(typeof(AbpDynamicApiControllerInterceptor<ITaskAppService>))
                        .LifestyleTransient()
            )
            .AddFacility<LoggingFacility>(f => f.UseLog4Net().WithConfig("log4net.config")); ;


            var apiController = container.Resolve<DynamicApiController<ITaskAppService>>();
            string result = apiController.GetTasks("do");
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
