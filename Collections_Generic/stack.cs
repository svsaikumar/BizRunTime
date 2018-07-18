using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Generic
{
    class stack
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);

            foreach(int i  in s)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
//generic stack is used to store the specific type of data into it
//duplicates are allowed
