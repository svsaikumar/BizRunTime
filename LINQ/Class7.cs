using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Class7
    {
        static void Main(string[] args)
        {
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            var stringResult = from s in mixedList.OfType<string>() select s;
            var intResult = from s in mixedList.OfType<int>() select s;
            foreach(var i in stringResult)
            {
                Console.WriteLine(i);
            }
            foreach (var i in intResult)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
