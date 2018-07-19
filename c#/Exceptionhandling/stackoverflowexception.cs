using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptionhandling
{
    class stackoverflowexception
    {
        static void Main(string[] args)
        {
            try
            {
                Main(null);
            }
            catch(StackOverflowException ex)
            {
                Console.WriteLine("catch executed");
            }
            finally
            {
                Console.WriteLine("finally block executed");
            }
            Console.WriteLine("done");
            Console.ReadKey();
        }
    }
}
