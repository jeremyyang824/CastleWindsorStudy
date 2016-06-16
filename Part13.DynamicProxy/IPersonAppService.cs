using System;
using System.Collections.Generic;

namespace Part13.DynamicProxy
{
    public interface IPersonAppService
    {
        IEnumerable<string> GetAllPeople();
    }
}
