using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rx.Net
{
    class timeSpan
    {
        public static void ReplaySubjectBuffer()
        {
            var window = TimeSpan.FromMilliseconds(50);
            var subject = new ReplaySubject<string>(window);
            subject.OnNext("a");
            Thread.Sleep(TimeSpan.FromMilliseconds(100));
            subject.OnNext("b");
            Thread.Sleep(TimeSpan.FromMilliseconds(1000));
            subject.OnNext("cb");
            subject.Subscribe(Console.WriteLine);
            subject.OnNext("d");
        }
        static void WriteSequenceToConsole(IObservable<string> sequence)
        {
            sequence.Subscribe(value => Console.WriteLine(value));
        }
        static void Main(string[] args)
        {
            ReplaySubjectBuffer();
            Console.ReadKey();
        }
    }
}