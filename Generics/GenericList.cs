using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{


    class GenericList
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
           
        }
    }
}
