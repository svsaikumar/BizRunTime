using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Text;

namespace Collections_Concurrent
{
    class concurrentstackMethods
    {
        static void Main(string[] args)
        {
            int result;
            ConcurrentStack<int> cs = new ConcurrentStack<int>();
            cs.Push(1);
            cs.Push(2);
            cs.Push(3);
            cs.Push(4);
            cs.Push(5);

            cs.TryPeek(out result);
            
            
            //Console.WriteLine(result);

            foreach (int i in cs)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
//Push(element) = add the elements to the stack in LIFO order
//TryPop(out variablename) = read and  removes the top element from the stack
//TryPeek(out variablename) = returns the top element from the stack but not removes it
//Count = used to determine the total number of elemets are there in stack
//Clear() = used to remove all the elements from the stack