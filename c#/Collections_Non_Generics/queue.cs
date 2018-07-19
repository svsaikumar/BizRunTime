using System;
using System.Collections;
using System.Text;

namespace Collections_Non_Generics
{
    class queue
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(2);
            q.Enqueue(2);
            q.Enqueue("test");
            q.Enqueue("hello");
            foreach (var v in q)
            {
                Console.WriteLine(v);
            }
            Console.ReadKey();
        }
    }
}
//duplicates are allowed
//it follows FirstInFirstOut order(FIFO)
///but the difference between arraylist and queue is , we can add element anywhere in arraylist, but in queue we can add at last only
//in case of removing also same