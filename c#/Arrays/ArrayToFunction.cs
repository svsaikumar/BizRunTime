using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class ArrayToFunction
    {
        public static void test(int []y)
        {
            foreach(int i in y)
            {
                Console.Write(i + ",");
            }
        }
        static void Main(string[] args)
        {
            int[] x = { 10, 20, 30 };
            test(x);
            Console.ReadKey();
        }
    }
}
