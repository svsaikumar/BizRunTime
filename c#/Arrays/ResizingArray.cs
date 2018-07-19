using System;
using System.Collections.Generic;
using System.Text;


namespace Arrays
{
    class ResizingArray
    {
        static void Main(string[] args)
        {
            string [] x = new string[4] { "10", "20", "30", "40" };
            Console.WriteLine("enter new size of array");
            int newSize = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref x, newSize);
            Console.WriteLine(string.Join(",", x));
            Console.ReadKey();


            
        }
    }
}
