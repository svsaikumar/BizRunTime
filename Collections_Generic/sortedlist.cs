using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Generic
{
    class sortedlist
    {
        static void Main(string[] args)
        {
            SortedList<string, object> s = new SortedList<string, object>();
            s.Add("id", 301);
            s.Add("name", "saikumar");
            s.Add("height", 5.6);
            //s.Add("height", 5.6);


            foreach (KeyValuePair<string, object> kvp in s)
            {
                Console.WriteLine(kvp);

            }
            Console.ReadKey();
        }
    }
}
//sortedlist is used to store the specific key-value generic pair elements
//elements are inserted on some sorting order
//duplicate keys are not allowed, but values can be duplicated
