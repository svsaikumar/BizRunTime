using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptionhandling
{


    class AgeException : DivideByZeroException
    {
        public override string Message
        {
            get
            {
                return "age should not be below 18";
            }
        }
    }
    
    class customexception
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (age >= 18)
                {
                    Console.WriteLine("success");
                }
                else
                {
                    throw new AgeException();
                }
            }
            catch(AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
