using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
     static class AddExtensionMethod
    {
        public static void Test3(this ExtensionMethods ex)
        {
            Console.WriteLine("from extension test3");
        }
        static void Main(string[] args)
        {
            ExtensionMethods ex = new ExtensionMethods();
            ex.Test3();
        }
    }
}

