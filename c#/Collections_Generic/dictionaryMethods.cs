using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Generic
{
    class dictionaryMethods
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> d = new Dictionary<string, object>();
            d.Add("id", 301);
            d.Add("name", "saikumar");
            d.Add("height", 5.6);
            d.Remove("name");
            
           // Console.WriteLine(d.ContainsKey("id"));
            //Console.WriteLine(d.ContainsValue("saikumar"));

            Console.WriteLine(d.GetType());
            Console.WriteLine(d.Count);
           





            foreach (KeyValuePair<string, object> kvp in d)
            {
                //Console.WriteLine(kvp);
            }
            Console.ReadKey();
        }
    }
}
//Add(key, value) = used to add key-value pair genric type of elements
//Remove(key) = used to remove the specific entry based on the key given from the Dictionary
//Clear() = used to remove all the key-value pair from the Dictinary
//Containskey(key) = used to check the availability of particular key in Dicionary
//ContainsValue(value) = used to check the availability of particular value in Dicionary
//GetType() = used to get the type of the data in Dictionary
//Count  =used to get the total number of elements in the Dictionary

//RemoveAt() method is not available in Dictionary

