using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Collections_Generic
{
    class dictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> d = new Dictionary<string, object>();
            d.Add("id", 301);
            d.Add("name", "saikumar");
            d.Add("height", 5.6);
            //d.Add("height", 5.6);//exception
            //d.Remove();

            foreach (KeyValuePair<string, object> d1 in d )
            {
                Console.WriteLine(d1);
            }
            Console.ReadKey();
        }
    }
}
//dictionary is used to store the key-value pair genereif type of elements into it
//it won't allow duplicates
//insertin order is preserved