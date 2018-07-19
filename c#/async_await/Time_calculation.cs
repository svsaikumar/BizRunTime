using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace async_await
{
    class Time_calculation
    {
        static void Main(string[] args)
        {
            test1();
            test2();
            Console.ReadKey();
        }
        static async void test1()
        {
            Console.WriteLine(DateTime.Now + ":test1 start");
            var i = Task.Delay(1000);
            var j = Task.Delay(1000);
            var k = Task.Delay(1000);
            var l = Task.Delay(1000);

            await i;
            await j;
            await k;
            await l;
            Console.WriteLine(DateTime.Now + ":test1 end");
        }

        static async void test2()
        {
            Console.WriteLine(DateTime.Now + ":test2 start");
            await Task.Delay(1000);
            await Task.Delay(1000);
            await Task.Delay(1000);
            await Task.Delay(1000);
            await Task.Delay(1000);
            Console.WriteLine(DateTime.Now + ":test2 end");
        }
    }
}
