using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    class StaticWithMultipleParameters
    {
        public static void test(int id, string name)
        {
            Console.WriteLine(id + ":" + name);
        }
        static void Main(string[] args)
        {
            test(1, "saikuamr");
            Console.WriteLine("from main");
            Console.ReadKey();
        }
    }
}
