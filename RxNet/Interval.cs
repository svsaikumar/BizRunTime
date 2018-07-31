using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Rx.net
{
    class Interval
    {       
        public static void NonBlocking_event_driven()
        {
            var ob = Observable.Create<string>(
            observer =>
            {
                var timer = new Timer();
                timer.Interval = 1000;
                timer.Elapsed += (s, e) => observer.OnNext("tick");
                timer.Elapsed += OnTimerElapsed;
                timer.Start();
                return Disposable.Empty;
            });
            var subscription = ob.Subscribe(Console.WriteLine);
            Console.ReadLine();
            subscription.Dispose();
        }
        public static void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(e.SignalTime);
        }
        static void Main(string[] args)
        {
            NonBlocking_event_driven();
            //OnTimerElapsed();
            Console.ReadLine();
        }
    }
}