using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{

    abstract class AbstractMethod1
    {
        public abstract void test();
    }
    class AbstractMethod : AbstractMethod1
    {
        public override void test()
        {
            Console.WriteLine("overriden method");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("from main");
            Console.ReadKey();
        }
    }
}
//while implementing virtual method or abstrct method we have to specify with 'override' keyword
