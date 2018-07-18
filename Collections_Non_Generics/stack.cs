using System;
using System.Collections;
using System.Text;

namespace Collections_Non_Generics
{
    class stack
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push("hello");
            s.Push(101);
            foreach (var v in s)
            {
                Console.WriteLine(v);
            }
            Console.ReadKey();
        }
    }
}
//we can insert only individual elements
//stack follows LastInFirstOut(LIFO), so when we are reading, the last inserted will be retrieved first

