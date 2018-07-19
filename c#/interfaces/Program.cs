using System;

namespace interfaces
{




    interface s
    {
        string Name
        {
            get;
            set;
            
        }
    }
    class Program
    {
        public string Name
        {
            get
            {
                return "saikumar";
            }
            set
            {
                Name = value;
            }
        }
        static void Main(string[] args)
        {
           // Test t = new Test();
            //Console.WriteLine(Test.id);
           // Console.WriteLine(t[0]);
        }
    }
}
