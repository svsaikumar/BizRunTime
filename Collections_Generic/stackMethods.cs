using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Collections_Generic
{
    class stackMethods
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Peek();
            s.Pop();
            //Console.WriteLine(s.Contains(2));
            Console.WriteLine(s.Count);
            //s.Clear();

            foreach (int i in s)
            {
                //Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
//Push(element) = used to store the generic types
//Peek() = used to read and remove the heading element from stack
//Pop() =used to read the heading element from stack
//Contains() = used to check the availability of specific generic type element in stack
//Count = used to get the total number of elements in the stack
//Clear() = used to remove all the elements  from the stack
