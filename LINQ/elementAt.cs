using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class elementAt
    {
        static void Main()
        {

            IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };

            IList<string> strList = new List<string>() { "One", null, "Three", "Four", "Five" };


            Console.WriteLine("1st Element in intList: {0}", intList.ElementAt(0));
            Console.WriteLine("1st Element in strList: {0}", strList.ElementAt(0));

            Console.WriteLine("2nd Element in intList: {0}", intList.ElementAt(1));
            Console.WriteLine("2nd Element in strList: {0}", strList.ElementAt(1));

            Console.ReadKey();

        }
    }
}
