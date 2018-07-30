using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Linq;
using System.Windows.Converters;

namespace RxNet
{
    class test1
    {
        static void Main(string[] args)
        {
            var helloWorld = Observable.Return("Hello, World!");

            //helloWorld.Subscribe(value => textBlock.Text = value);
        }
    }
}
