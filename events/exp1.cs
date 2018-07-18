using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events
{
    public delegate void FirstDelegate();
   
    class exp1
    {

        public event FirstDelegate FirstEvent;


        public void test1()
        {
            //event1();
            Console.WriteLine("test1");
        }
        public void test2()
        {
            //event1();
            Console.WriteLine("test2");
        }
        public void event1()
        {
            Console.WriteLine("event executed");
        }
        static void Main(string[] args)
        {
           exp1  e1 = new exp1();
           FirstDelegate d1 = e1.test1;
                         d1 += e1.test2;
                          
                        //e1.FirstEvent += d1.event1;


            d1.Invoke();
            
            
        }
    }
}
