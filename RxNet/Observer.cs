using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reactive.Linq;
using System.Threading;

namespace Rx.Net
{
    class Observer : IObserver<int>
    {
        public void OnNext(int value)
        {
            var threadId = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.Write($"value recieved on thread with Id {threadId}...");
            //Step-3
            Console.WriteLine(value);
        }
        public void OnError(Exception error)
        {
            var threadId = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.Write($"error recieved on thread with Id {threadId}...");
            Console.WriteLine($"Error: {error.Message}");
        }
        public void OnCompleted()
        {
            var threadId = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"completed on thread with Id {threadId}...");
            Console.WriteLine("Observation complete.");
        }
    }
}