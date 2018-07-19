using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{


     interface a
    {
         void Test();
    }
   
    class interface1 : a
    {
        public  void Test()
        {
            Console.WriteLine("implementation in child class");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("from main method");
        }
    }
}
//by default declared methods in interface are public and abstract
//when we are implementing we have mention as public
//by default, interface is internal
//interface can't be private and protected
//an interface can't be sealed
