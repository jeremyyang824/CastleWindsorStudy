using System;
using System.IO;
using Commons.Collections;
using NVelocity;
using NVelocity.App;

namespace Part10.SetterInjection
{
    public class NVelocityMessageFormatter : IMessageFormatter
    {
        private readonly Template _template;

        public NVelocityMessageFormatter(string templateFile)
        {
            VelocityEngine velocity = new VelocityEngine();
            ExtendedProperties props = new ExtendedProperties();
            velocity.Init(props);
            _template = velocity.GetTemplate(templateFile);
        }

        public string FormatMessage(string from, string to, string body)
        {
            VelocityContext context = new VelocityContext();
            context.Put("from", from);
            context.Put("to", to);
            context.Put("body", body);
            context.Put("today", DateTime.Now);

            StringWriter writer = new StringWriter();
            _template.Merge(context, writer);

            return writer.ToString();
        }
    }
}
