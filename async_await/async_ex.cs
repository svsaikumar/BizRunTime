using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace async_await
{
    class async_ex
    {

        static void Main(string[] args)
        {
            Console.WriteLine("1");
            MyMethodAsync();
            Console.WriteLine("5");
            Console.ReadKey();
        }

        public async static void MyMethodAsync()
        {
            Console.WriteLine("2");
            Task<int> longRunningTask = LongRunningOperationAsync();

            int result = await longRunningTask;

            Console.WriteLine("4");
        }

        public async static Task<int> LongRunningOperationAsync()
        {
            Console.WriteLine("3");
            await Task.Delay(0);
            return 1;
        }
    }
}
