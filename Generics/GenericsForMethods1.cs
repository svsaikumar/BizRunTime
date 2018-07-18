using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{


    class GenericsForMethods
    {
        public void Add<T>(T i, T j)
        {
            dynamic d1 = i;
            dynamic d2 = j;
            Console.WriteLine(d1 + d2);
        }
        public void Sub<T>(T i, T j)
        {
            dynamic d1 = i;
            dynamic d2 = j;
            Console.WriteLine(d1 - d2);
        }
        public void Mul<T>(T i, T j)
        {
            dynamic d1 = i;
            dynamic d2 = j;
            Console.WriteLine(d1 * d2);
        }
    }

    class GenericsForMethods1
    {
        static void Main(string[] args)
        {
            GenericsForMethods gm = new GenericsForMethods();
            gm.Add(40, 20);
            gm.Sub(40, 20);
            gm.Mul(40, 20);
            Console.ReadKey();

        }
    }
}
