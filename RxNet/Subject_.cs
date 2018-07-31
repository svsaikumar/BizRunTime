using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.Net
{
    class Subject_
    {
        static void WriteSequenceToConsole(IObservable<string> sequence)
        {
            sequence.Subscribe(value => Console.WriteLine(value));
        }
        static void AsyncSubject(Subject<string> subject)
        {
            subject.OnNext("a");
            WriteSequenceToConsole(subject);
            subject.OnNext("b");
            subject.OnNext("c");
            subject.OnNext("d");
            subject.OnCompleted();
        }
        static void Main(string[] args)
        {
            var subject = new Subject<string>();
            AsyncSubject(subject);
            Console.ReadKey();
        }
    }
}