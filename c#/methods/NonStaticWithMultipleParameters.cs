using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    class NonStaticWithMultipleParameters
    {
        public void test(int i, int j)
        {
            Console.WriteLine("the value of i and j are :{0}, {1}", i, j);
        }
        static void Main(string[] args)
        {
            NonStaticWithMultipleParameters n = new NonStaticWithMultipleParameters();
            n.test(10, 20);
            Console.WriteLine("from main");
            Console.ReadKey();
        }
    }
}
