using System;

namespace InterceptorAttributeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            TestMethod();

            Console.ReadKey();
        }

        [FodyLog]
        private static void TestMethod()
        {
            Console.WriteLine("Test Method");

            //throw new Exception();
        }
    }
}
