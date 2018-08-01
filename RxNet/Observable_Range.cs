using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;

namespace RxNet
{
    class Observable_Range
    {
        static void Main(string[] args)
        {
            var range = Observable.Range(10, 15);
            range.Subscribe(Console.WriteLine, () => Console.WriteLine("Completed"));
        }
    }
}
