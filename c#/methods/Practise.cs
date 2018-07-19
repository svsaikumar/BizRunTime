using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{


    class Employee
    {
        public  virtual void Test()
        {
            Console.WriteLine("employee");
        }
        
    }
    class Manager : Employee
    {
        public override void Test()
        {
            Console.WriteLine("manager ");
        }
    }
    class Developer : Employee
    {
        public override void Test()
        {
            Console.WriteLine("developer ");
        }
    }
    class Practise
    { 
        static void Main(string[] args)
        {
            Employee e1 = new Manager();
            e1.Test();
            Console.ReadKey();
        }
    }

}
