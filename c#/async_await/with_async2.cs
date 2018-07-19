using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace async_await
{
    class with_async2
    {
        static void Main(string[] args)
        {
            test1();
            test2();
            Console.ReadKey();
        }
        static async void test1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("from test-1:" + i);
                }
            });
        }
        
        static void test2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("from test-2:" + i);
            }

        }
    }
}
