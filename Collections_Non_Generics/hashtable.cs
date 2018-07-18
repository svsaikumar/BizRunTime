using System;
using System.Collections;
using System.Text;

namespace Collections_Non_Generics
{
    class hashtable
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            table.Add("id", 101);
            table.Add(1, "saikumar");
            table.Add("city", "banglore");
            foreach(DictionaryEntry d in table)
            {
                Console.WriteLine(d.Key + ":" + d.Value);
            }
            Console.ReadKey();
        }
    }
}
//"DictonaryEntry" is a class whose object represents the data in a combination of key & value pairs.
//insertion order is based on the hashcode of the keys
//retived through key of elemetrns
//keys can be of any data type(baecause any type of comparision is not doing here)