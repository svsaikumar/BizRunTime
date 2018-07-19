using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events
{
    public delegate void MyDelegate1();
    class event1
    {
        public static event MyDelegate1 Event1;
        public static event MyDelegate1 Event2;
        static void Main(string[] args)
        {
            Event1 += test1;
            Event2 += test2;

            Event1();
            Event2();
            Console.ReadKey();
        }
        static void test1()
        {
            Console.WriteLine("test1");
        }
        static void test2()
        {
            Console.WriteLine("test2");
        }
    }
}
//  MyDelegate1 md1 = new MyDelegate1(test1);
// md1 += new MyDelegate1(test2);

// md1.Invoke();