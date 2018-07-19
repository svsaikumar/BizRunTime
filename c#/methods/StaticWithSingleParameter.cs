using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    class StaticWithSingleParameter
    {
        public static void test(string name)
        {
            Console.WriteLine("from test:" + name);
        }

        static void Main(string[] args)
        {
            test("saikumar");
            Console.WriteLine("from main");
            Console.ReadKey();
        }

    }
}
