using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{
    class testing_indexer_in_interface
    {
        static void Main(string[] args)
        {
            indexer_in_interface a = new indexer_in_interface();
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            Console.WriteLine(a[3]);
            Console.WriteLine("====================");
            a[1] = 801;
            a[2] = "babu";
            a[3] = "hyderabad";
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            Console.WriteLine(a[2]);
            Console.ReadKey();
        }
    }
}
