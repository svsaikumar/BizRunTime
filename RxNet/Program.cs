using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reactive.Linq;
using System.Threading;


namespace Rx.Net
{
    public class test
    {
        static void Main(string[] args)
        {
            var threadId = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"Program started on main thread with Id {threadId}...");
            //step-1
            var observable = Observable.Range(5, 8);

            //step-2
            var subscription = observable.Subscribe(new Observer());

            Console.ReadKey();

            //step-4
            subscription.Dispose();
        }
    }
}