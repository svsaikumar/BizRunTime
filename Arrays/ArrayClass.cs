using System;
using System.Collections.Generic;
using System.Text;


namespace Arrays
{
    class ArrayClass
    {
        static void Main(string[] args)
        {
            Array array1 = Array.CreateInstance(typeof(string), 4);
            array1.SetValue("saikumar",0);
            array1.SetValue("student", 1);

            foreach(string s in array1)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();

            int s1 = Array.BinarySearch(array1, "saikumar");
            Console.WriteLine(s1);
            Console.ReadKey();
        }
    }
}
