using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace async_await
{
    class without_async2
    {
        static void Main(string[] args)
        {
            test1();
            test2();
            Console.ReadKey();
        }
        static void test1()
        {        
            for(int i = 1; i < 100; i++)
            {
                Console.WriteLine("from test1:" + i);
            }           
        }
        static void test2()
        {    
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("from test2:" + i);
            }
           
        }
    }
}
