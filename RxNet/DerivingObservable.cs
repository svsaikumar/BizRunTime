using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxNet
{
    interface IObservable<T>
    {
        void Subscribe(Action<T> action);
        void UnSubscribe(Action<T> action);
    }
    class DerivingObservable : IObservable<int>
    {
        private event Action<int> action = null;
        public void Subscribe(Action<int> action)
        {
            this.action += action;
        }
        public void UnSubscribe(Action<int> action)
        {
            this.action -= action; 
        }
    }
}
