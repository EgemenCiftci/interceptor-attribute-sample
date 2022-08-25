using System;

namespace InterceptorAttributeSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TestMethod();

            _ = Console.ReadKey();
        }

        [FodyLog]
        private static void TestMethod()
        {
            Console.WriteLine("Test Method");

            //throw new Exception();
        }
    }
}
