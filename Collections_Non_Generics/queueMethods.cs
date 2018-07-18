using System;
using System.Collections;
using System.Text;

namespace Collections_Non_Generics
{
    class queueMethods
    {
        static void Main(string[] args)
        {
            //IComparable
              // IComparer
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue("hello");
            q.Enqueue(1);
            q.Dequeue();
            q.Peek();
            
            


            foreach (var v in q)
            {
                //Console.WriteLine(v);
            }
            Console.ReadKey();
        }
    }
}
//Enqueue(Object) = is used to add any type of elements into queue(duplicates also)
//Dequeue() = used to read and remove the begining element in queue
//Peek() = used to read the beginning element in queue
//Clear() = used to remove all the elements from queue