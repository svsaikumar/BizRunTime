using System;


using System.Collections.Generic;
using System.Text;

namespace methods
{
    class NonStaticWithSingleParameter
    {
        public void test(int i)
        {
            Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            NonStaticWithSingleParameter n = new NonStaticWithSingleParameter();
            n.test(10);
            Console.WriteLine("from main");
            Console.ReadKey();
        }
    }
}
