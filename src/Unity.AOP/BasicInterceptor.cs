using System;
using System.Collections.Generic;
using Unity.Interception.InterceptionBehaviors;
using Unity.Interception.PolicyInjection.Pipeline;

namespace Lithium.Unity.AOP
{
    public class BasicInterceptor : IInterceptionBehavior
    {
        public bool WillExecute => true;

        public IEnumerable<Type> GetRequiredInterfaces()
        {
            return Type.EmptyTypes;
        }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
        {
            // input.MethodBase;
            throw new NotImplementedException();
        }
    }
}
