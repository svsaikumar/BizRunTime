using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Text;

namespace Collections_Concurrent
{
    class concurrentBagMethods
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
            cb.Add(5);
            
            cb.TryTake(out result);
            cb.TryPeek(out result);
            //Console.WriteLine(result + "=");
            foreach (var v in cb)
            {
                Console.WriteLine(v);
            }
            Console.ReadKey();
        }
       
    }
}
//Add() = used to add the elements into the bag
//TryTake(out variable) = used to read and remove the recently added element(if duplicates are there, it will remove only that elements)
//TryPeek(out variable) = used to read the recently added element, it won't remove any element
