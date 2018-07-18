using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{

    interface f
    {
        void test();
        void show();
    }
    interface g
    {
        void test();
        void show();
    }
    class implementing_multiple_methods : f,g
    {
        public void test()
        {
            Console.WriteLine("implementing test");
        }
        void f.show()
        {
            Console.WriteLine("implementing show() of f");
        }
        void g.show()
        {
            Console.WriteLine("implementing show() of g");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("from main");
            Console.ReadKey();
        }
    }
}
