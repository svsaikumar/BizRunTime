using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace async_await
{
    class using_async
    {
        static void Main(string[] args)
        {
            Method();
            Console.WriteLine("main thread");
            Console.ReadKey();
        }
        static async void Method()
        {
            await Task.Run(new Action(Test));
            Console.WriteLine("new thread");
        }
        static void Test()
        {
            Thread.Sleep(200);
        }
    }
}
