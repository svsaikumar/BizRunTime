using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class DeclaringArray
    {
        static void Main(string[] args)
        {
            int[] x = new int[3];//first way to declare and initialize the array
            x[0] = 10;
            x[1] = 20;
            x[2] = 30;

            int[] y = new int[3] { 10, 20, 30 };//second way to declare and initialize an arry

            int[] z = new int[] { 10, 20, 30 };//third way to declare and initialize the array

            int[] a = { 10, 20, 30 };//fourth way to declare and initialize an array

            Console.WriteLine(string.Join(",", x));
            Console.WriteLine(string.Join(",", y));
            Console.WriteLine(string.Join(",", z));
            Console.WriteLine(string.Join(",", a));
            Console.ReadKey();


        }
    }
}
