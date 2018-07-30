using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxNet
{
    class subscribing
    {
        static void Main(string[] args)
        {
            test();
            Console.WriteLine("press any key to exit the program");
            Console.ReadKey();
        }
        static void test()
        {
            var obseravable = new Implementing_IObservable(5, 8);

            var observer = new MyObserver<int>();

            var subscription = obseravable.Subscribe(observer);

            Console.WriteLine("press any key to dispose the subscription");
            Console.ReadKey();
            subscription.Dispose();

        }
    }
}
