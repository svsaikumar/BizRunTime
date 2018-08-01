using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Reactive.Linq;

namespace RxNet
{
    class Observable_Start_Time
    {
        static void Main(string[] args)
        {
            var start = Observable.Start(() =>
            {
                Console.Write("starting... ");
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(100);
                    Console.Write( i + " ");
                } 
                return "Published value";
            });
            start.Subscribe(
            Console.WriteLine,
            () => Console.WriteLine("Action completed"));
            Console.ReadKey();
        }
    }
}
