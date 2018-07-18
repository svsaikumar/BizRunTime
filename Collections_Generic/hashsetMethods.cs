using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Generic
{
    class hashsetMethods
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(4);
            set.Remove(4);
            set.Contains(4);


            foreach (var v in set)
            {
                Console.WriteLine(v);
            }
            Console.ReadKey();
        }
       
    }
}
//Ad(element) = used to store the specific generic type element
//Remove(element) = to remove the specific element
//Count = gives the total number of elements in the set
//Contains() = checks whether the particular elemetn is available in stack or not
//Clear() = removes the all the elements from the set