using System;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;

namespace Part03.DictionaryConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            WindsorContainer container = new WindsorContainer(new XmlInterpreter());

            AliasService aliasService = container.Resolve<AliasService>();

            string sentence = "a dog ate my homework";
            foreach (string word in sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
            {
                Console.Write("{0} ", aliasService.Evaluate(word));
            }

            Console.Read();
        }
    }
}
