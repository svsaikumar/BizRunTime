using System;

namespace Arrays
{
    class Program
    {


        static void Main(string []args)
        {
            Console.WriteLine("enter 2 numbers");
            int a = Convert.ToInt16(args[0]);
            int b = Convert.ToInt16(args[1]);
           
            
            int c = a + b;
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
