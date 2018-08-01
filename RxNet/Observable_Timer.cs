using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;

namespace RxNet
{
    class Observable_Timer
    {
        static void Main(string[] args)
        {
            var timer = Observable.Timer(TimeSpan.FromSeconds(3));
            timer.Subscribe(Console.WriteLine,
            () => Console.WriteLine("completed"));
            Console.ReadKey();
        }
    }
}
