using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Subjects;

namespace RxNet
{
    class Dispose
    {
        static void Main(string[] args)
        {
            var subject = new Subject<int>();
            var subscription = subject.Subscribe(Console.WriteLine);
            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnNext(3);
            subject.Dispose();
            try
            {
                subject.OnNext(4);
                subject.OnNext(5);
            }
            catch
            {

            }          
            Console.ReadKey();
        }
    }
}
