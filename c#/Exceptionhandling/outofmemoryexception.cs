using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptionhandling
{
    class outofmemoryexception
    {
        static void Main(string[] args)
        {
            try
            {
                String s = new String('a', int.MaxValue);
            }
            catch(OutOfMemoryException ex)
            {
                Console.WriteLine(ex.Message);   
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
