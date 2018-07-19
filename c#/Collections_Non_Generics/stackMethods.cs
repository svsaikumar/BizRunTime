using System;
using System.Collections;
using System.Text;

namespace Collections_Non_Generics
{
    class stackMethods
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push("hello");
            s.Push(10.2);
            s.Push(10.2);
            s.Peek();
            s.Pop();
            // s.Clear();
           
            foreach (var v in s)
            {
                Console.WriteLine(v);
            }
            Console.ReadKey();
        }
    }
}
//stack allows any type of individual elements
//stack allows duplicates
//it follows ListInFirstOut(LIFO) order
//we can read the elements in LIFO order


//Push(Object) = for adding elements into Stack(duplicates also allowed)
//Peek() = for reading the head element from stack
//Pop() = for reading and removing the head element from stack
//Clear() = for removing the all the elements from the stack
//Count() = for count the total number of elements in stack

