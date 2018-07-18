using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Generic
{
    class hashset
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(4);
            set.Add(4);//it won't allow duplicates


            foreach (var v in set)
            {
                Console.WriteLine(v);
            }
            Console.ReadKey();
        }
    }
}
//Hashet generic type is used to store the specific type of elements
//it won't allow duplicates
//insertion order is preserved