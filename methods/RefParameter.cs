using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    class RefParameter
    {
        public static void test(int i,int j, ref int k, ref int l)
        {
            k = i + j;
            l = i * j;
        }
        static void Main(string[] args)
        {
            int p = 0; int q = 0;
            test(10, 20, ref p, ref q);
            Console.WriteLine(p + "," +  q);
            Console.ReadKey();
        }
    }
}
//ref parameter values will go inside method, so they have to be initialized before going inside method
