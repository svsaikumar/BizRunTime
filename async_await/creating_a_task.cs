using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace async_await
{
    class creating_a_task
    {
        static void Main(string[] args)
        {
            Thread t1 = Thread.CurrentThread;
            t1.Name = "main";
            //Task t = new Task();
            Task t = new Task(test);
            t.Start();
            t.Wait();
            Console.WriteLine("after task:" + t1.Name);
            Console.ReadKey();

        }
        public static void test()
        {
            Thread t = Thread.CurrentThread;
            t.Name = "child";
            for (int i = 0; i < 100; i++)
                Console.WriteLine("hello:" + i + " " + t.Name);
        }
    }
}
