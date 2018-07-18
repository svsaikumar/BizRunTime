using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class RankOfArrays
    {

        static void Main(string[] args)
        {
            int[] o = { 10, 20, 30 };
            int[,] x = { { 10, 20 }, { 10, 20 } };
            int[,] y = new int[3, 2] { { 10, 20 }, { 30, 40 }, { 50, 60 } };
            int[,,] z = { { { 10, 20, 30 }, { 10, 20, 30 } } };
            int[][] j = new int[3][];
            j[0] = new int[]{ 10,20,30,40};
            j[1] = new int[] { 10, 20 };
            j[2] = new int[] { 10, 20, 30 };

            Console.WriteLine(o.Rank);//1
            Console.WriteLine(x.Rank);//2
            Console.WriteLine(y.Rank);//2
            Console.WriteLine(z.Rank);//3
            Console.WriteLine(j.Rank);//1
            Console.ReadKey();
        } 
    }
}
//for single dimensional array rank is no.of rows or no.columns
//for multi dimensional array rank is based on the dimensional
