using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Generic
{
    class queueMethods
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("hello");
            q.Enqueue("world");
            q.Enqueue("test");
            q.Enqueue("java");
            q.Enqueue("java");
            q.Dequeue();
            Console.WriteLine(q.Contains("java"));
            q.Peek();
            //q.Clear();

            foreach (var v in q)
            {
                //Console.WriteLine(v);
            }
            Console.ReadKey();
        }
    }
}
//Enqueue(object) = used to add the elements in to the queue
//Dequeue() = read and removes the first element from the queue
//Peek() = reads the begining element from the queue
//Contains() = checks whether the specific element is available in stack or not
//Count = used to determine the no.of elements available in queue
//Clear() = used to remove all the elements from the queue
