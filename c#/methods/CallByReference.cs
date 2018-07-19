using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    class CallByReference
    {
        public static void test(ref int j)
        {
            j = 20;
            Console.WriteLine("value inside method is;" + j);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("call by reference");
            int i = 10;
            Console.WriteLine("value before method call is :" + i);
            test(ref i);
            Console.WriteLine("Value of method call is:" + i);
            Console.ReadKey();
        }
    }
}
//in callbyreference we send the referncece itself, it will reflect the original value