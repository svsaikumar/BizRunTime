using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class singleOrDefault
    {
        static void Main(string[] args)
        {
            IList<string> emptyList = new List<string>();
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            Console.WriteLine("Element in emptyList: {0}", emptyList.SingleOrDefault());

            Console.WriteLine("The only element which is less than 10 in intList: {0}",intList.Single(i => i < 10));
            Console.ReadKey();
        }
    }
}
