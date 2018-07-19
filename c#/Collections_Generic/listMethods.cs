using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Generic
{
    class listMethods
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            //list.Insert(1,10);
            list.Remove();
            Console.WriteLine(list.BinarySearch(4));
            Console.WriteLine(list.Contains(5));

            foreach(var v in list)
            {
                Console.WriteLine(v);
            }
            Console.ReadKey();
        }
    }
}
//Add(element) = List element is used to add elements to List(of similar type only)
//Insert(index, value) = used to add elements at specific index
//Remove(element) = used remove the specific element from list
//RemoveAt(index) = used to remive the specific indexed element from lists
//BinarySearch(element) = searches for a specific element and returns index if it is there(it returns -5 if it is not there)
//Clear() = used to clear all the elements for list
//Contains(elemetn) = used to check the availability of specific element 
