using System;
using System.Collections.Generic;
using System.Text;


namespace Arrays
{
    class CopyingOfArray
    {
        static void Main(string[] args)
        {
            int []x = { 30, 40, 50 };
            int []y = { 10, 20, 1, 2, 3, 60, 70 };
            Console.WriteLine(string.Join(",", y));
            x.CopyTo(y,2);//2 represent that source elemenst has to be added from 2 index in destination array
            Console.WriteLine(string.Join(",", y));
            Console.ReadKey();
        }
    }
}
