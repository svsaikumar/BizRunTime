using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace RxNet
{
    class Observable_Throw
    {
        static void Main(string[] args)
        {
            var throws = Observable.Throw<string>(new Exception());
            //Behaviorally equivalent to
            var subject = new ReplaySubject<string>();
            subject.OnError(new Exception());
            Console.ReadKey();


            //var throws = Observable.Throw<string>(new Exception());
            //throws.Subscribe(Console.WriteLine, () => Console.WriteLine("Completed"));
            //Console.ReadKey();
         
        }
    }
}
