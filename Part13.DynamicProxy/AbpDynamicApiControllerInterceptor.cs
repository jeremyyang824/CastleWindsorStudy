using System;
using System.Collections.Generic;
using System.Linq;
using Castle.DynamicProxy;

namespace Part13.DynamicProxy
{
    public class AbpDynamicApiControllerInterceptor<T> : IInterceptor
    {
        private readonly T _proxiedObject;

        public AbpDynamicApiControllerInterceptor(T proxiedObject)
        {
            _proxiedObject = proxiedObject;
        }

        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Intercept...");
            invocation.ReturnValue = typeof(T).GetMethod(invocation.Method.Name).Invoke(_proxiedObject, invocation.Arguments);
            //invocation.Proceed();
        }
    }
}
