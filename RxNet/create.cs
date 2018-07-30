using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Disposables;

namespace RxNet
{
    class create 
    {
        static void Main(string[] args)
        {
            IObservable<int> observable = Observable.Create<int>(observer =>
            {
                try
                {
                    observer.OnNext(1);
                    observer.OnNext(2);
                    observer.OnNext(3);

                    //throw new Exception("Oops!");

                    observer.OnCompleted();
                }
                catch(Exception ex)
                {
                    observer.OnError(ex);
                }

                return Disposable.Empty;
            });
            var subscription = observable.Subscribe(

                Console.WriteLine,
                ex => Console.WriteLine(ex.Message),
                () => Console.WriteLine("completed"));

            Console.WriteLine("disposing subscription");
            subscription.Dispose();
            Console.WriteLine("disposed successfully");
            Console.ReadKey();
                
        }

      
    }
}
