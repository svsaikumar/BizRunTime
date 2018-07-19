using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class GenericMethod1
    {

        public void test<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }
    class GenericMethod
    { 
        static void Main(string[] args)
        {
            GenericMethod1 gc1 = new GenericMethod1();
            gc1.test("hello");
            gc1.test(10);
            Console.ReadKey();
        }
    }
}
