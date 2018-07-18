using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{

    class LengthOfArray
    {
        static void Main(string[] args)
        {
            int[] x = { 10, 20 };//single dimensional array
            int[,] y = { { 10, 20, 30 }, { 10, 20, 30 } };//multi dimensional array
            int[,] z = new int[3, 2] {{ 10, 20 },{ 30,40}, { 50,60} };
            int[][] j = new int[3][];//jagged array
            j[0] = new int[]{ 10,20,30};
            j[1] = new int[] { 10, 20 };
            j[2] = new int[] { 10, 20, 30, 40 };
            

            Console.WriteLine(x.Length);//2
            Console.WriteLine(y.Length);//6
            Console.WriteLine(z.Length);//6
            Console.WriteLine(j.Length);//3
            Console.ReadKey();
        }

    }
}
//For single dimensional array length is no.of rows or no.of columns;
//Multidemensionla array length is (no.of rows * no of.columns)
//for jagged array length is no of rows only
