using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{
    class testing_property_in_interface
    {
        static void Main(string[] args)
        {
            prop pi = new property_in_interface();
            Console.WriteLine(pi.Name);
            pi.Name = "venkata";
            Console.WriteLine(pi.Name);
            Console.ReadKey();
        }
    }
}
