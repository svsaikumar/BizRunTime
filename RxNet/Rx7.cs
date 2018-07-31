using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.Net
{
    class Rx7
    {
        static void Subject(Subject<string> subject)
        {
            WriteSequenceToConsole(subject);
            subject.OnNext("Welcome");
            subject.OnNext("To");
            subject.OnNext("India");
        }
        static void WriteSequenceToConsole(IObservable<string> sequence)
        {
            sequence.Subscribe(value => Console.WriteLine(value));
        }
        static void Main(string[] args)
        {
            var subject = new Subject<string>();
            Subject(subject);
            Console.ReadKey();
        }
    }
}