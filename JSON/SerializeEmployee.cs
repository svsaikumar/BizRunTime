using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToCObject
{
    class SerializeEmployee
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(102, "kumar", "nellore");
            string json = JsonConvert.SerializeObject(e1, Formatting.Indented);
            Console.WriteLine(json);
            Console.ReadKey();
        }
    }
}
