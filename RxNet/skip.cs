using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxNet
{
    class skip
    {
        static void Main(string[] args)
        {
            Observable.Range(1, 10)
            .Skip(3)
            .Subscribe(Console.WriteLine, () => Console.WriteLine("Completed"));
            Console.ReadKey();
        }
    }
}
