using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Text;

namespace Collections_Concurrent
{
    class concurrentqueueMethods
    {
        static void Main(string[] args)
        {
            int result;
            Object obj;
            ConcurrentQueue<int> cq = new ConcurrentQueue<int>();
            cq.Enqueue(1);
            cq.Enqueue(1);
            cq.Enqueue(2);
            cq.Enqueue(3);
            cq.Enqueue(4);
            cq.Enqueue(5);
            cq.TryDequeue(out result);
            cq.TryPeek(out result);
           // cq.Clear();
            Console.WriteLine(cq.Count);
            //Console.WriteLine(result);



            foreach (int i in cq)
            {
                //Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
//Enqueue() = adds the element in to the queue
//TryDequeue(out variablename) = removes the heading element from the queue
//TryPeek(out variablename) = returns the heading element
//Count = returns the total number of elements present in the queue
//Clear() = removes all the elements ffom the queue