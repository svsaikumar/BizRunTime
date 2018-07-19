using System;
using System.Collections;
using System.Text;

namespace Collections_Non_Generics
{
    class sortedlist
    {
        static void Main(string[] args)
        {
            SortedList list = new SortedList();
            list.Add("id", 201);
            list.Add("name", "saikumar");
            list.Add("city", "banglore");
           
            foreach (DictionaryEntry d in list)
            {
                Console.WriteLine(d.Key + ":" + d.Value);
            }
            Console.ReadKey();
        }
    }
}
//sorted list also stores elements in key-value pair
//but the items are inserted in some sorting order
//by default sorting order is ascending order of keys
//keys must be of same type(because comparision is happening)
