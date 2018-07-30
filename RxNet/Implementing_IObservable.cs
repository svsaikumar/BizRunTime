using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;
 

namespace RxNet
{
    public class Implementing_IObservable : IObservable<int>
    {
        private int start;
        private int count;
        public Implementing_IObservable(int start, int count)
        {
            this.start = start;
            this.count = count;
        }
        public IDisposable Subscribe(IObserver<int> observer)
        {
            try
            {
                for(int i = start; i < start + count; i++)
                {
                    observer.OnNext(i);
                }
                observer.OnCompleted();
                return new MyDisposable();
            }
            catch(Exception ex)
            {
                observer.OnError(ex);
                return new MyDisposable();
            }
        }
    }
}
