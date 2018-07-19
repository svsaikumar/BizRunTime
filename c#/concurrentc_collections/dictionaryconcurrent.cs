using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

using System.Text;

namespace Collections_Concurrent
{
    class dictionaryconcurrent
    {
        static void Main(string[] args)
        {
            ConcurrentDictionary<string, object> cd = new ConcurrentDictionary<string, object>();
            cd.TryAdd("id", 101);
            cd.TryAdd("name", "saikumar");
            cd.TryAdd("city", "banglore");
            cd.TryAdd("city", "hyderabad");

            foreach(KeyValuePair<string, object> kvp in cd)
            {
                Console.WriteLine(kvp);
            }
            Console.ReadKey();
        }
         
    }
}
//store the generic type key -value pair into it
//elements are sorted based on the key(follows some sorting order
