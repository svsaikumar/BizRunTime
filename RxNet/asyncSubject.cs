using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.Net
{
    class asyncSubject
    {
        
       
        static void Main(string[] args)
        {
            var subject = new AsyncSubject<string>();
            subject.Subscribe(value => Console.WriteLine(value));
            subject.OnNext("a");          
            subject.OnNext("b");
            subject.OnNext("c");
            subject.OnCompleted();
            Console.ReadKey();
        }
    }
}
// similar to the Replay and Behavior subjects in the way that it caches values,
//however it will only store the last value, and only publish it when the sequence is completed.
//The general usage of the AsyncSubject<T> is to only ever publish one value then immediately complete.