using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{


    interface d
    {
         void test();
    }
    interface e
    {
        void test();
    }

    class individual_implementation : d,e
    {
        void d.test()
        {
            Console.WriteLine("implementatin of test() of d");
        }
        void e.test()
        {
            Console.WriteLine("implementatin of test() of e");
        }
        static void Main(string[] args)
        {

            Console.WriteLine("from main method");
            Console.ReadKey();
        }
    }
}
