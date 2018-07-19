using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    class NestedMethods
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main method");
            void test()
            {
                Console.WriteLine("local method");
                void test1()
                {
                    Console.WriteLine("local inner methd");
                }
                test1();
            }
            test();
            Console.ReadKey();
        }
    }
}
//in c# nested methods are allowed.
//but they have to be called within the context