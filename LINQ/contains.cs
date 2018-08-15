using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class contains
    {
        public static void Main()
        {
            IList<int> intList = new List<int>() { 1, 2, 3, 4, 5 };

            bool result = intList.Contains(10);

            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
