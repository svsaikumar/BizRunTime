using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{

    interface b
    {
        void test();
    }
    interface c
    {
        void test();
    }

    class multipleinheritance :b,c
    {
        public void test()//this implementatin apply for both interfaces
        {
            Console.WriteLine("from derived class");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" from main method");
            Console.ReadKey();
        }
    }
}
