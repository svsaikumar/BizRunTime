using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Generic
{
    class list
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            //list.Add("hello"); //error
            //list.Add(10.2); //error
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
//List_generic is used to store only one type of data
//size is not fixed
//List allow duplicates
//insertion order is preserved