using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptionhandling
{
    class formatexception
    {  
        static void Main(string[] args)
        {
            Console.Write("enter first Number:");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter second Number:");
            int j;
          
            try
            {
                j = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(i + "," + j);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
