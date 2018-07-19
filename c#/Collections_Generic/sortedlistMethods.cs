using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Generic
{
    class sortedlistMethods
    {
        static void Main(string[] args)
        {
            SortedList<string, object> s = new SortedList<string, object>();
            s.Add("id", 301);
            s.Add("name", "saikumar");
            //s.Add("height", 5.6);
            s.Remove("id");
            s.RemoveAt(1);
            //s.ContainsKey("id");
            //s.ContainsValue("saikumar");
            //s.Clear();
            Console.WriteLine(s.GetType());

            Console.WriteLine(s.Capacity);


            foreach (KeyValuePair<string, object> kvp in s)
            {
                //Console.WriteLine(kvp);

            }
            Console.ReadKey();
        }
    }
}
//Add(key, value) = used to add key-value generic type elements
//Remove(key) = used to remove the specific key-value pair from the list
//RemoveAt(index) = used to remove the specific indexed key-value pair from list
//Containskey(key) = used to check the availability of particular key in list
//ContainsValue(value) = used to check the availability of particular value in list
//GetType() = used to get the type of the data in Dictionary
//Clear() = used the clear the entire list
//Count = used to get the total number of elements in the list
//Capacity() = used to get the total size of the list

