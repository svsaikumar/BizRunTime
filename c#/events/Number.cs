using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events
{
    class Number
    {
        PrintHelper _printHelper = new PrintHelper();
         
        private int _value;

        public Number(int val)
        {
            _value = val;

           
            //"PrintHelper" object is subscribing to "beforePrintEvent"  event of PrintHelper class



            _printHelper.beforePrintEvent += printHelper_beforePrintEvent;
            



            //before this delegate executes,   this will execute
        }
        //beforePrintevent handler
        void printHelper_beforePrintEvent(int i)
        {
            Console.WriteLine("BeforPrintEventHandler: PrintHelper is going to print a value");
        }

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public void PrintNumber()
        {
            _printHelper.PrintNumber(_value);
        }
        public void PrintDecimal()
        {
            _printHelper.PrintDecimal(_value);
        }
        public void PrintMoney()
        {
            _printHelper.PrintMoney(_value);
        }
        static void Main(string[] args)
        {
            Number myNumber = new Number(100);
            myNumber.PrintNumber();
            myNumber.PrintDecimal();
            myNumber.PrintMoney();
         
            Console.ReadKey();
        }
        
    }
}
