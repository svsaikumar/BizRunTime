using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Class8
    {
        static void Main(string[] args)
        {
            int[] x = { 20, 10, 30, 5, 40, 8, 2, 60, 1 };

            var result = from s in x  orderby s descending select s;
            foreach(var i in result)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
