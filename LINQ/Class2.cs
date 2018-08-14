using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Class2
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 97, 92, 81, 60 };
          
            var scoreQuery = from score in scores where score > 80 select score;

            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
        }
    }
}
