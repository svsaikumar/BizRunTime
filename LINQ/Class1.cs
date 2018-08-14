using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "hello", "wonderful", "LINQ", "beautiful", "world" };

            var shortWords = from word in words where word.Length <= 5 select word;
             
            foreach (var word in shortWords)
            {
                Console.WriteLine(word);
            }
            Console.ReadKey();
        }
    }
}
