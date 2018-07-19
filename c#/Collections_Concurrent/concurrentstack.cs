using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Text;

namespace Collections_Concurrent
{
    class concurrentstack
    {
        static void Main(string[] args)
        {
            ConcurrentStack<int> cs = new ConcurrentStack<int>();
            cs.Push(1);
            cs.Push(2);
            cs.Push(3);
            cs.Push(4);
            cs.Push(5);

            foreach(int i in cs)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
//used to store specific type of elements where duplicates are allowed
//it follows LIFO order