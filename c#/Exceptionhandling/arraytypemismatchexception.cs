using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptionhandling
{
    class arraytypemismatchexception
    {
        static void Main(string[] args)
        {
            int[] x = new int[1];
           
            try
            {
                 x[0] = Convert.ToInt32(Console.ReadLine());
          
            }
            catch(ArrayTypeMismatchException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("done");
            Console.ReadKey();
        }
    }
}
