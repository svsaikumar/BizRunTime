using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Generic
{
    class queue
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("hello");
            q.Enqueue("world");
            q.Enqueue("test");
            q.Enqueue("java");
            q.Enqueue("java");

            foreach (var v in q)
            {
                Console.WriteLine(v);
            }
            Console.ReadKey();
        }
    }
}
//queue with generic stores the specific type of data where duplicates are also allowed
//it follows FirstInFirstOut order
