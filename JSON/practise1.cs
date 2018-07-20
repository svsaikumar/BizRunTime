using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToCObject
{
    class practise1
    {
        static void Main(string[] args)
        {
            var details = " { \"id\":5, \"name\":\"sai\", \"city\":\"btm\"}";

            var obj = JsonConvert.DeserializeObject<Practise>(details);

           // Console.WriteLine("id:" + obj.id);
            //Console.WriteLine("name:" + obj.name);
            //Console.WriteLine("city:" + obj.city);
            Console.ReadKey();
        }
    }
}
