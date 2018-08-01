using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Subjects;
using System.Reactive.Linq;

namespace RxNet
{
    class skipwhile
    {
        static void Main(string[] args)
        {
            var subject = new Subject<int>();
            subject
            .SkipWhile(i => i < 4)
            .Subscribe(Console.WriteLine, () => Console.WriteLine("Completed"));
            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnNext(3);
            subject.OnNext(4);
            subject.OnNext(5);
            subject.OnNext(6);
            subject.OnNext(7);
            subject.OnNext(8);
            subject.OnCompleted();
            Console.ReadKey();
        }
    }
}
