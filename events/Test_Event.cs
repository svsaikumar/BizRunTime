using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events
{
    class Test_Event
    {
        public delegate void MyDelegate(int i);
        public event MyDelegate MyEvent;


        public  void test(int value)
        {
            Console.WriteLine("from test method:" + value);
        }


      /*  public void RaiseEvent()
        {
            MyEvent(10);//calling a event which automatically calls delegate
            Console.WriteLine("Event Raised");
        }
        */


        public void Display(int x)
        {
            Console.WriteLine("Diaplay Event: {0}", x);
        }
        static void Main(string[] args)
        {
            Test_Event obj = new Test_Event();
                                                         //MyDelegate Md = obj.Display;
            obj.MyEvent += new MyDelegate(obj.Display);//calling a delegate and event is assigning to it
                                                       //obj.RaiseEvent();//calling a method
            obj.MyEvent(10);
            Console.ReadKey();
        }
    }
}
