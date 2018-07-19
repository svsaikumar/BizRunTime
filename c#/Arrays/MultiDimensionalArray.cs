using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class MultiDimensionalArray
    {
        static void Main(string[] args)
        {
            int[,] x = new int[3, 3];
            x[0, 0] = 10;
            x[0, 1] = 20;
            x[0, 2] = 30;
            x[1, 0] = 40;
            x[1, 1] = 50;
            x[1, 2] = 60;
            x[2, 0] = 70;
            x[2, 1] = 80;
            x[2, 2] = 90;
            //one way to intialize the multidemensional array
            int rowLength = x.GetLength(0);
            int columnLength = x.GetLength(1);

            //another way to initialize the multidimensional array
            int[,] y = new int[3, 3] { { 90, 80, 70 }, { 60, 50, 40 }, { 30, 20, 10 } };

            
            for(int r = 0; r < rowLength; r++)
            {
                for(int c = 0; c < columnLength; c++)
                {
                    Console.Write(x[r, c] + " ");
                }
                Console.WriteLine();
            }

           
            Console.ReadKey();
        }
        
    }
}
