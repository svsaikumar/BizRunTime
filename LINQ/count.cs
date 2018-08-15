using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class count
    {
        static void Main()
        {
            IList<int> intList = new List<int>() { 10, 21, 30, 45, 50 };

            var totalElements = intList.Count();

            Console.WriteLine("Total Elements: {0}", totalElements);

            var evenElements = intList.Count(i => i % 2 == 0);

            Console.WriteLine("Even Elements: {0}", evenElements);
            Console.ReadKey();

        }
    }
}
