using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace JsonToCObject
{
    class DeSeralizeStudent
    {
        static void Main(string[] args)
        {
            var client = new WebClient();
            var text = "{\"id\":101, \"name\":\"saikumar\", \"city\":\"bengaluru\"}";

            Console.WriteLine(text);

            Student s1 = JsonConvert.DeserializeObject<Student>(text);
            Console.WriteLine("id:" + s1.id);
            Console.WriteLine("name:" + s1.name);
            Console.WriteLine("city:" + s1.city);

            Console.ReadKey();
        }
    }
}
