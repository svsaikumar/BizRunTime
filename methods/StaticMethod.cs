using System;

namespace methods
{
    class StaticMethod
    {



        public static void test()
        {
            Console.WriteLine("from test()");
        }
        static void Main(string[] args)
        {
            test();
            Console.WriteLine("from main");
            Console.ReadKey();
        }
    }
}
//we can call a static method directly.no need of instance reference