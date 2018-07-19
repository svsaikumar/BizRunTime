using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace async_await
{
    class returning_result_task
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main start");
            test();
            Console.WriteLine("main end");
            Console.ReadKey();
        }
        static async void test()
        {
            Task<int> i = Test1();
            int value = await i;
            Console.WriteLine(value);
        }
        static async Task<int> Test1()
        {
            await Task.Delay(0);
            return 1;
        }
    }
}
