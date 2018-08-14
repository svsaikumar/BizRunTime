using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Class5
    {
        static void Main(string[] args)
        {
            IList<string> stringList = new List<string>() {
            "C# Tutorials",
            "VB.NET Tutorials",
            "Learn C++",
            "MVC Tutorials" ,
            "Java"
        };

           
            var result = stringList.Where(s => s.Contains("Tutorials"));


            foreach (var str in result)
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }
}
