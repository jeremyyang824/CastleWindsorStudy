using System;

namespace Part13.DynamicProxy
{
    public interface ITaskAppService 
    {
        string GetTasks(string taskName);

        void CreateTask(string taskName);
    }
}
