using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;
using System.Reactive.Linq;

namespace RxNet
{
    class Observer_Event
    {
        public static event EventHandler SimpleEvent;
        static void Main()
        {
            // To consume SimpleEvent as an IObservable:
            var eventAsObservable = Observable.FromEventPattern(
                ev => SimpleEvent += ev,
                ev => SimpleEvent -= ev);
            Console.ReadKey();
        }
    }
}
