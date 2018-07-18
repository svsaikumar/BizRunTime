using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptionhandling
{
    class divisionbyzeroexception
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 0;
            int k = i/j;
            
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
