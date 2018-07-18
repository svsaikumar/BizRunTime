using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events
{
    public delegate void BeforePrint(int i); // declare delegate 
    public class PrintHelper
    {
        
        public event BeforePrint beforePrintEvent;//declare event of type delegate
        //"beforeprintevent" is an object of type "BeforePrint" delegate


        public void PrintNumber(int num)
        {
            //call delegate method before going to print
            if (beforePrintEvent != null)
            {
                beforePrintEvent(10);
                Console.WriteLine("first");
            }
            else
            {
                Console.WriteLine("Number: {0,-12:N0}", num);
            }   
        }
        public void PrintDecimal(int dec)
        {
            if (beforePrintEvent != null)
            {
                 beforePrintEvent(20);
                Console.WriteLine("second");
            }
            else
            {
                Console.WriteLine("Decimal: {0:G}", dec);
            }   
        }
        public void PrintMoney(int money)
        {
            if (beforePrintEvent != null)
            {
                beforePrintEvent(30);
                Console.WriteLine("third");
            }
            else
            {
                Console.WriteLine("Money: {0:C}", money);
            }    
        }
        public void test()
        {
            Console.WriteLine("test");
        }
        static void Main(string[] args)
        {
            PrintHelper ph = new PrintHelper();
            BeforePrint BP = ph.PrintNumber;
                        BP += ph.PrintDecimal;
                        BP += ph.PrintMoney;
                        BP += ph.beforePrintEvent;
            BP.Invoke(10);
            
            Console.ReadKey();

        }
    }
}

//beforePrintEvent is an object of type BeforPrint delegate, so it would be null if no class is subscribed to the event

