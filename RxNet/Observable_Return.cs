using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;
using System.Reactive.Linq;

namespace Rx.Net
{
    class Observalble_Return
    {
        static void Main(string[] args)
        {
            var data = Observable.Return("hello to all");
            data.Subscribe(Console.WriteLine, () => Console.WriteLine("Completed"));
            Console.ReadKey();
        }
    }
}
