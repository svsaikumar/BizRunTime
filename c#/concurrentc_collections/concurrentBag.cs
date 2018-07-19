using System;
using System.Collections.Generic;

using System.Collections.Concurrent;
using System.Text;

namespace Collections_Concurrent
{
    class concurrentBag
    {
        static void Main(string[] args)
        {
            int result;
            ConcurrentBag<int> cb = new ConcurrentBag<int>();
            cb.Add(1);
            cb.Add(2);
            cb.Add(3);
            cb.Add(4);
            cb.Add(5);
             //cb.Add(5);
            cb.TryTake(out result);
            Console.WriteLine(result +"=");
            foreach (var v in cb)
            {
                Console.WriteLine(v);
            }
            Console.ReadKey();
        }
    }
}
//used to stroe the generic type elements 
//duplicates are allowed
//insertin order is preserved
//it follows LIFO order

