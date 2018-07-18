using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptionhandling
{
    class return1
    {
        public static string test(bool flag)
        {
            try
            {
                return "try";
            }
            catch
            {
                return "catch";
            }
            finally
            {
               
            }
            return "out";

        }
        static void Main(string[] args)
        {
            bool flag = true; 
            string s  = test(flag);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
