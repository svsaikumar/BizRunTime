using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    class CallByValue
    {
        public static void test(int j)
        {
            j = 20;
            Console.WriteLine("value inside mthod:" + j);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("call by value");
            int i = 10;
            Console.WriteLine("Value before method is:" + i);
            test(i);
            Console.WriteLine("Value after method call is:" + i);
            Console.ReadKey();
        }
    }
}
//in call by value , we are sending the value, it won't change the original value
