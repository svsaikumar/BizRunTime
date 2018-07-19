using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    class NonStaticMethod
    {
        public void test()
        {
            Console.WriteLine("from non-static test");
        }
        static void Main(string[] args)
        {
            NonStaticMethod n = new NonStaticMethod();
            n.test();
            Console.WriteLine("from main");
            Console.ReadKey();
        }
    }
}
