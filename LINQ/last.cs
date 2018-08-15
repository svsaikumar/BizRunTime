using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class last
    {
        static void Main(string[] args)
        {
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
           

            Console.WriteLine("Last Element in intList: {0}", intList.Last());

            Console.WriteLine("Last Element in strList: {0}", strList.Last());
            Console.ReadKey();
        }
    }
}
