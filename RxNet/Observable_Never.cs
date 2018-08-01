using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;

namespace RxNet
{
    class Observable_Never
    {
        static void Main(string[] args)
        {
            var data = Observable.Never<string>("hello to all");
            data.Subscribe(Console.WriteLine, () => Console.WriteLine("Completed"));
            Console.ReadKey();
        }
    }
}
