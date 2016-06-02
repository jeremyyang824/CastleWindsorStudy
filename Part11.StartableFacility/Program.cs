using System;
using System.Net;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;

namespace Part11.StartableFacility
{
    class Program
    {
        static void Main(string[] args)
        {
            WindsorContainer container = new WindsorContainer(new XmlInterpreter());

            GetPage();
            container.Dispose(); //回收容器后自动停止服务

            GetPage();

            Console.Read();
        }

        private static void GetPage()
        {
            Console.WriteLine("\r\nClient: requesting http://localhost:8089/ ...");
            try
            {
                WebClient client = new WebClient();
                string content = client.DownloadString("http://localhost:8089/");
                Console.WriteLine("Client: success, content follows.rnrn {0}", content);
            }
            catch (WebException ex)
            {
                Console.WriteLine("Client: Exception occured, message: {0}", ex.Message);
            }
        }
    }
}
