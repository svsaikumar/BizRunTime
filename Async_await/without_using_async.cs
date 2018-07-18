using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace async_await
{
    class without_using_async
    {
        static void Main(string[] args)
        {
            test();
            Console.WriteLine("main thread");
            Console.ReadKey();
        }
        static  void test()
        {
            Task.Run(new Action(method));
            Console.WriteLine("New Thread");
        }
        static void method()
        {
            Thread.Sleep(20000);          
        }
    }
}
