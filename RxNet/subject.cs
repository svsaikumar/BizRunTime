using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace RxNet
{
    class subject
    {
        static void Main(string[] args)
        {
            var subject = new Subject<int>();
            var subscription = subject.Subscribe(Console.WriteLine);
            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnNext(3);
            subject.OnNext(4);
            subject.OnNext(5);
            Console.ReadKey();

        }

    }
}
