using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class sum
    {
        static void Main()
        {
            IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };

            var total = intList.Sum();

            Console.WriteLine("Sum: {0}", total);

            var sumOfEvenElements = intList.Sum(i => {
                if (i % 2 == 0)
                    return i;
                return 0;
            });

            Console.WriteLine("Sum of Even Element: {0}", sumOfEvenElements);
            Console.ReadKey();
        }
    }
}
