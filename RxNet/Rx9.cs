using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rx.net
{
    class Rx9
    {
        static void Call<T>(IObservable<T> source, string name)
        {
            source.Subscribe(
          i => Console.WriteLine("{0}-->{1}", name, i),
          ex => Console.WriteLine("{0} failed-->{1}", name, ex.Message),
          () => Console.WriteLine("{0} completed", name));
        }

        static void CountExample()
        {
            var numbers = Observable.Range(0, 3);
            Call(numbers, "Number");
            Call(numbers.Count(), "Count");
        }


        static void Main(string[] args)
        {
            CountExample();
            Console.ReadKey();

        }
    }
}