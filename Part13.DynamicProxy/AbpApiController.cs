using System;
using System.Collections.Generic;
using Castle.Core.Logging;

namespace Part13.DynamicProxy
{
    public class AbpApiController
    {
        public ILogger Logger { get; set; }

        public AbpApiController()
        {
            Logger = NullLogger.Instance;
        }
    }
}
