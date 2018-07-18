using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    class NonVirtualMethods1
    {
        public void test()
        {
            Console.WriteLine("from base test");
        }
        class NonVirtualMethods : NonVirtualMethods1
        {
            
            public void test()
            {
                Console.WriteLine("from derived test");
            }
            static void Main(string[] args)
            {
                NonVirtualMethods1 n = new NonVirtualMethods();
                n.test();
                Console.ReadKey();
            }
        }
    }
}
//by using normal way, method calling is happend on the reference type
//in this case super class is not aware of overriding it's methd in subclass

//A virtual method is a type of method where the actual method calls depends on the runtime type of the underlying object.

//A non-virtual method is a type of method where the actual method called depends on the reference type of the object
//at the point of method invocation.
