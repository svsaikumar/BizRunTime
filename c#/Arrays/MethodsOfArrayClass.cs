using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class MethodsOfArrayClass
    {

        static void Main(string[] args)
        {
            int[] x = { 10, 20, 30, 40 };
            int[] y = { 50, 60, 70, 80, 90 };
            Array.Copy(x, y, 2);//x is source array, y is destinatin array, 2 is how many has to copy from soruce array
            Console.WriteLine(string.Join(",",y));
            Console.ReadKey();


            int[] x1 = { 10, 20, 30, 40 };
            int[] y1 = { 50, 60, 70, 80, 90 };
            Array.Copy(x1, 1, y1, 2, 3);
            //x1 is source. 1 is from 1st index has to copy, y1 is destination array, 2 is from which index in destinatin, 3 how
            //many elements has to be taken from source index
            Console.WriteLine(string.Join(",", y1));
            Console.ReadKey();

            int[] s = { 10, 50, 20, 80, 52, 40, 90 };
            Array.Sort(s);
            Console.WriteLine(string.Join(",", s));
            Console.ReadKey();

            int[] s1 = { 10, 50, 20, 80, 52, 40, 90 };
            Array.Sort(s1,2,3);//sorting only 3 elements from 2nd index in array s1
            Console.WriteLine(string.Join(",", s1));
            Console.ReadKey();

            int[] r = { 10, 20, 30, 40 };
            Array.Reverse(r);
            Console.WriteLine(string.Join(",", r));
            Console.ReadKey();

            int[] r1 = { 10, 20, 30, 40,50,60 };
            Array.Reverse(r1,2,3);//reversing only 3 elements from 2nd index in array r1
            Console.WriteLine(string.Join(",", r1));
            Console.ReadKey();


            int[] c = { 10, 20, 30, 40, 50, 60, 70, 80 };
            Array.Clear(c, 2, 4);//clearing only 4 elements from 2nd index(
            Console.WriteLine(string.Join(",", c));//after clearing that indexes defalut values will be there
            Console.ReadKey();



        } 
    }
}
//copy method is associated with array class
//CopyTo method is associated with array object