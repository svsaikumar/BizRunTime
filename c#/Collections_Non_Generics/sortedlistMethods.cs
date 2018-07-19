using System;
using System.Collections;
using System.Text;

namespace Collections_Non_Generics
{
    class sortedlistMethods
    {
        static void Main(string[] args)
        {
            SortedList list = new SortedList();
            list.Add("id", 101);
            list.Add("name", "saikumar");
            list.Add("city", "nellore");
            // list.Add("city", "nellore");  error
            Console.WriteLine(list.Count);
            list.Remove("city");//removes the entry from the list whose key is "city"
            //list.RemoveAt(1);//removes the entry at specific index
            list.Clear();
            foreach (DictionaryEntry d in list)
            {
                Console.WriteLine(d.Key + ":" + d.Value);
            }
            Console.ReadKey();
        }
    }
}
//we have to insert only similar type of data as keys(because comparision is happening)
//keys can't be duplicated, but values can be duplicated

//Add(object key, Object value) = for adding any type of data into list(all keys should be of same type)
//Remove(key) = for removing the specific key from list
//RemoveAt(index) = for removing the entry from list at given index
//Clear() = for removing all the elements from sorterd list