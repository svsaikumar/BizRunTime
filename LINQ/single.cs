using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class single
    {
        static void Main(string[] args)
        {
            IList<int> oneElementList = new List<int>() { 6,7,8 };
                    
            Console.WriteLine("The only element in oneElementList: {0}", oneElementList.Single());
            
            Console.ReadKey();
        }
    }
}
