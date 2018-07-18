using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    class VirtualMethods1
    {
        public virtual void test()
        {
            Console.WriteLine("from virtual method");
        }
    }
    class VirtualMethods : VirtualMethods1
    {
        public override void test()
        {
            Console.WriteLine("from override method");
        }
        static void Main(string[] args)
        {
            VirtualMethods1 v1 = new VirtualMethods1();
            v1.test();
            Console.WriteLine("from main");
            Console.ReadKey();
        }
    }
}
// if we use virtual methods, then the method call is based on the type of the object(right hand side)
//incase of virtual, parent class gives permission to override the particular method in child class, so parent can
//aware of impelemtation of that methd in child(by using parent we can call child)
//but this is not possible incase of non-virtual methods

//A virtual method is a type of method where the actual method calls depends on the runtime type of the underlying object.

//A non-virtual method is a type of method where the actual method called depends on the reference type of the object
//at the point of method invocation.