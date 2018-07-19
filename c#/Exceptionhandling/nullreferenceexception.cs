using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptionhandling
{
    class nullreferenceexception
    {
        static string s = null;
        static void Main(string[] args)
        {
           
            int i;
            try
            {
               i = s.Length;
                Console.WriteLine(i);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("done");
            Console.ReadKey();
        }
    }
}
