using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.net
{
    class replaySubject
    {
       
        static void Main(string[] args)
        {
            var subject = new ReplaySubject<string>();
            subject.OnNext("a");
            subject.Subscribe(value => Console.WriteLine(value));
            subject.OnNext("b");
            subject.OnNext("c");
            subject.OnNext("d");
            Console.ReadKey();
        }
    }
}