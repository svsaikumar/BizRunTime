using System;
using System.Collections;
using System.Text;

namespace Collections_Non_Generics
{
    class arraylist
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("saikumar");
            list.Add("banglore");
            foreach (var v in list)
            {
                Console.WriteLine(v);
            }
            Console.ReadKey();
        }
    }
}
//insertion order is preserved
//duplicates are allowed