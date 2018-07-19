using System;
using System.Collections;
using System.Text;

namespace Collections_Non_Generics
{
    class hashtableMethods
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            //adding elements into table
            table.Add("id", 101);
            table.Add(1, "saikumar");
            table.Add("city", "banglore");
            table.Add("place", "banglore");
            table.Remove("city");//removing an entry based of key
            table.Clear();
            table.Clone();
          
            Console.WriteLine(table.ContainsKey("place"));//checking for specific key availability
            Console.WriteLine(table.ContainsValue("banglore"));//checking for specific value availability
            foreach (DictionaryEntry d in table)
            {
                Console.WriteLine(d.Key + ":" + d.Value);
            }
            Console.ReadKey();
        }
    }
}
//we can insert any type of keys into the table
//keys can't be duplicated, but values can be duplicated

//Add(object) =  we can add any type of data into table
//Remove(elemetn) = for removing spefic elemetn from table
//Clear() = removes all the elements from table
//Clone() = creates a shallow copy of Hashtable
//