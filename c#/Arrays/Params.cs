using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class Params
    {
        public void test(params int[]x)
        {
            foreach(int i in x)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Params p1 = new Params();
            p1.test(10, 20);
            Console.WriteLine("==================");
            p1.test(10, 20,30,40);
            Console.ReadKey();
        }
    }
}
