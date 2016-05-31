using System;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;

namespace Part08.ReferencingImplementationsByKey
{
    class Program
    {
        static void Main(string[] args)
        {
            WindsorContainer container = new WindsorContainer(new XmlInterpreter());

            FileReader defaultReader = container.Resolve<FileReader>();
            FileReader file1Reader = container.Resolve<FileReader>("reader.file1");
            FileReader file2Reader = container.Resolve<FileReader>("reader.file2");

            Console.WriteLine("Default contents: {0}", defaultReader.ReadToEnd());
            Console.WriteLine("File1 contents: {0}", file1Reader.ReadToEnd());
            Console.WriteLine("File2 contents: {0}", file2Reader.ReadToEnd());

            Console.Read();
        }
    }
}
