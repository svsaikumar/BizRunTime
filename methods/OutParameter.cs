using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    class OutParameter
    {
        public static void Test(int i, int j, out int k, out int l)
        {
            k = i + j;
            l = i * j;
        }
        static void Main(string[] args)
        {
            int m = 10 , n = 20;

            int p = 0, q = 0;

            Test(m, n, out p, out q);
            //Test(m,n, out int p, out int q);

            Console.WriteLine(p + "" + q);
            Console.ReadKey();
        }
    }
}
//'out' keyword is used to return multiple values 
//out parameter variable values will not go inside  method, so they have to be initialized before coming out from method
//as out parameter variables are not sending inside the method, why they need to initialized