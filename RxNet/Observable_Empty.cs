using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace RxNet
{
    class Observable_Empty
    {
        static void Main(string[] args)
        {
            var data = Observable.Empty<string>("hello to all");
            data.Subscribe(Console.WriteLine, () => Console.WriteLine("Completed"));
            Console.ReadKey();
        }
    }
}
