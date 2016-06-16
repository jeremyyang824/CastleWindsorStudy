using System;

namespace Part13.DynamicProxy
{
    public class TaskAppService : ITaskAppService
    {
        public string GetTasks(string taskName)
        {
            return taskName + " TaskAppService";
        }

        public void CreateTask(string taskName)
        {
            return;
        }
    }
}
