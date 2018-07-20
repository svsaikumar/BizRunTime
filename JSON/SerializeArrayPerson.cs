using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToCObject
{


    class SerializeArrayPerson
    {
        static void Main(string[] args)
        {
            var json = new List<PeopleList>();
            Person p1 = new Person { name = "sai", age = 20 };
            json.Add(new PeopleList { inputs = p1 });
            Person p2 = new Person { name = " kumar", age = 30 };
            json.Add(new PeopleList { inputs = p2 });

            string jsonString = JsonConvert.SerializeObject(json);
            Console.WriteLine(jsonString);
            Console.ReadKey();
        }

    }
}
