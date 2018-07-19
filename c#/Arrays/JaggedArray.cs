using System;
using System.Collections.Generic;
using System.Text;


namespace Arrays
{
    class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] x = new int[3][];
            x[0] = new int[4] { 10, 20, 30, 40 };
            x[1] = new int[2] { 10, 20 };
            x[2] = new int[3] { 10, 20, 30 };

            for(int i = 0; i < x.Length; i++)
            {
                for(int j = 0; j < x[i].Length; j++ )
                {
                    Console.Write(x[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
//jagged array means array inside an array
