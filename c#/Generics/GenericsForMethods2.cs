using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{

    class GenericForMethods<T>
    {
        public void Add(int i, int j)
        {
            Console.WriteLine(i + j);
        }
        public void Sub(int i, int j)
        {
            Console.WriteLine(i - j);
        }
        public void Mul(int i, int j)
        {
            Console.WriteLine(i * j);
        }
    }
    class GenericsForMethods2
    {
        static void Main(string[] args)
        {
            GenericForMethods<int> gm = new GenericForMethods<int>();
            gm.Add(50, 25);
            gm.Sub(50, 25);
            gm.Mul(50, 25);
            Console.ReadKey();

        }
    }
}
