using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Text;

namespace Collections_Concurrent
{
    class dictionaryconcurrentMethods
    {
        static void Main(string[] args)
        {
            object value;
            ConcurrentDictionary<string, object> cd = new ConcurrentDictionary<string, object>();
            cd.TryAdd("id", 101);
            cd.TryAdd("name", "saikumar");
            cd.TryAdd("city", "banglore");
            cd.TryAdd("city", "hyderabad");
            //Console.WriteLine(cd.TryGetValue("city", out value));
            Console.WriteLine(cd.TryUpdate("city", "nellore", "banglore"));
            Console.WriteLine(cd.TryRemove("city", out value));
            // cd.AddOrUpdate("id", 101, ("id", 1) => 102);
            //cd.AddOrUpdate(i, i * i, (k,v) => v / i);
            //cd.AddOrUpdate(1, 1, (key, oldValue) => oldValue + 1);
            Console.WriteLine(cd.GetOrAdd("id1", 102));


            foreach(KeyValuePair<string, object> kvp in cd)
            {
                //Console.WriteLine(kvp);
            }
            Console.ReadKey();
        }
    }
}
//TryAdd(key, value) = used to add the elements into the dictionary
//TryGetValue(key, out T) = returns true if the specific value if available, else returns false
//TryUpdate(key, new_value, old_value) = check for that particular key corresponding value is available or not,if available it returns true,
                //else it returns false

//TryRemove(key , out variable) = removes and returns true if the specific key_value pair, is available , else it returns false
//GetorAdd(key, value)= if key already exists, it returns the old value, or else creaets new key and returns  new value

