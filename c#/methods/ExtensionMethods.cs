using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{


     
      sealed class ExtensionMethods 
    {
        public void Test1()
        {
            Console.WriteLine("noramal method test1");
        }
        public void Test2()
        {
            Console.WriteLine("noramal method test2");
        }
        static void Main(string[] args)
        {
            ExtensionMethods e1 = new ExtensionMethods();
            e1.Test1();
            e1.Test2();
            Console.WriteLine("from main");
            Console.ReadKey();
        }
    }
}
