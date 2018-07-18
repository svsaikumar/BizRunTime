using System;
using System.Collections.Generic;
using System.Text;


namespace Generics
{
    

    class GenericClass1<T>
    {
        public GenericClass1(T msg)
        {
            Console.WriteLine(msg);
        }
    }
    class GenericClass
    {
        static void Main(string[] args)
        {
            GenericClass1<string> gen = new GenericClass1<string>("This is generic class");
            GenericClass1<int> genI = new GenericClass1<int>(101);
            GenericClass1<char> getCh = new GenericClass1<char>('I');
            Console.ReadKey();
        }
    }
}
