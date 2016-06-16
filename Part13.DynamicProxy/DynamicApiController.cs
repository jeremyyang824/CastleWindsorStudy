using System;

namespace Part13.DynamicProxy
{
    public class DynamicApiController<T> : AbpApiController, IDynamicApiController
    {
        //必须是virtual
        public virtual string GetTasks(string taskName)
        {
            return taskName + " DynamicApiController";
        }
    }
}
