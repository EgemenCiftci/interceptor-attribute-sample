using MethodBoundaryAspect.Fody.Attributes;
using System;

namespace InterceptorAttributeSample
{
    public sealed class FodyLogAttribute : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.WriteLine("Log: On entry");
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Console.WriteLine("Log: On exit");
        }

        public override void OnException(MethodExecutionArgs args)
        {
            Console.WriteLine("Log: On exception");
        }
    }
}
