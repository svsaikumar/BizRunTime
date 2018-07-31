using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.Net
{
    class behaviourSubject
    {
       
        static void Main(string[] args)
        {
            var subject = new BehaviorSubject<int>(0);
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
