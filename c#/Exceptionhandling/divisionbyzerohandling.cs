using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptionhandling
{
    class divisionbyzerohandling
    {
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 0;
            int x;
            try
            {
                x = a / b;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            Console.WriteLine("done");
            Console.ReadKey();
        }
    }
}
