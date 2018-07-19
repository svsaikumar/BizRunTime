using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Text;

namespace Collections_Concurrent
{
    class concurrentqueue
    {
        static void Main(string[] args)
        {
            ConcurrentQueue<int> cq = new ConcurrentQueue<int>();
            cq.Enqueue(1);
            cq.Enqueue(2);
            cq.Enqueue(3);
            cq.Enqueue(4);
            cq.Enqueue(5);
            cq.Enqueue(5);
            cq.Enqueue(5);

            foreach(int i in cq)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
//stores the specific generic type elements in FIFO order
//duplicates are allowed
