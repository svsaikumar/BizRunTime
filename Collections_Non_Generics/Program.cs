using System;
using System.Collections.Concurrent;
using System.Collections;
using System.Collections.Generic;
namespace Collections_Non_Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            ConcurrentDictionary<string, object> cd = new ConcurrentDictionary<string, object>();
            cd.TryAdd("id", 101);
            cd.TryAdd("name", "saikumar");
            cd.TryAdd("city", "banglore");
            Console.WriteLine(cd.TryAdd("city", "banglore"));
            Console.WriteLine(cd.TryUpdate("city", "nellore", "banglore"));
      

            foreach (KeyValuePair<string, object> kvp in cd)
            {
                Console.WriteLine(kvp);
            }
            Console.ReadKey();
        }
    }
}
