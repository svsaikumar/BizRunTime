using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events
{
    public class PrintHelper1
    {
        /*
        // declare delegate 
        public delegate void BeforePrint(int i);

        //declare event of type delegate
        public event BeforePrint beforePrintEvent;

        public PrintHelper1()
        {

        }

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


        static void Main(string[] args)
        {
            PrintHelper1 p1 = new PrintHelper1();
            p1.PrintNumber(10);
            p1.PrintDecimal(20);
            p1.PrintMoney(30);
        }
        */
    }
}
