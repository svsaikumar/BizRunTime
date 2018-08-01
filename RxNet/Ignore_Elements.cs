using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Subjects;
using System.Reactive.Linq;

namespace RxNet
{
    class Ignore_Elements
    {
        static void Main(string[] args)
        {
            var subject = new Subject<int>();           
            var noElements = subject.IgnoreElements();

            subject.Subscribe(i => Console.WriteLine("subject.OnNext({0})", i),
            () => Console.WriteLine("subject.OnCompleted()"));

            noElements.Subscribe(i => Console.WriteLine("noElements.OnNext({0})", i),
            () => Console.WriteLine("noElements.OnCompleted()"));

            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnNext(3);
            subject.OnCompleted();
            Console.ReadKey();
        }
    }
}
