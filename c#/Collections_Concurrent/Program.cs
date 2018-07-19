using System;
using System.Collections.Generic;

namespace Collections_Concurrent
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> d = new Dictionary<string, object>();
            d.TryAdd("id", 201);
            d.TryAdd("name", "saikumar");
            d.TryAdd("city", "banglore");
            d.TryAdd("city", "hyderabad");
            foreach(KeyValuePair<string,object>kvp in d)
            {
                Console.WriteLine(kvp);
            }
            Console.ReadKey();
        }
    }
}
