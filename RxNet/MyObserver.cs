using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxNet
{
    public class MyObserver<T> : IObserver<T>
    {
       
        private string name = null;
        public MyObserver(string subscribeName = "Subscriber 1")
        {
            name = subscribeName;
        }
        public virtual void OnCompleted()
        {
            Console.WriteLine("Observation completed by "  + name);
        }
       
        public void OnError(Exception error)
        {
            Console.WriteLine("An error occured while " + name + "oberving:" + error.Message);
        }

        public void OnNext(T value)
        {
            Console.WriteLine(name + " received:" + value.ToString());
        }
    }
}
