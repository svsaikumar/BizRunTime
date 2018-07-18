using System;
using System.Collections.Generic;
using System.Text;



namespace Arrays
{
    class SingleDimensionalArray
    {
        static void Main(string[] args)
        {
            int[] x = new int[5] { 10, 20, 30, 40, 50 };//one way to initilize
            int[] y = { 60,70,80,90,100 };//another way to initialize
           


            //printing elements of array using for loop
            for(int i = 0;i < x.Length; i++)
            {
                Console.Write(x[i] + ",");
            }
            //printing elements of array using foreach loop
            foreach(int i in y)
            {
                Console.Write(i + ",");
            }
            //printing all the elemetns at once
            Console.WriteLine(string.Join(",", x));
            Console.ReadKey();
        }
    }
}
