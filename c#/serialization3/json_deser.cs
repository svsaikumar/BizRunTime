using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Runtime.Serialization;

namespace serialization3
{
    class json_deser 
    {
        static void Main(string[] args)
        {
            
            FileStream stream1 = new FileStream(@"S:\BizRuntime\training\c#\serial_files\employee_json.json", FileMode.Open);

            //serializes the object to JSON
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(json_ser));
            json_ser e2 = (json_ser)ser.ReadObject(stream1);
            Console.WriteLine("deserialization done");
            Console.WriteLine(e2.id);
            Console.WriteLine(e2.name);
            Console.WriteLine(e2.place);
            Console.ReadKey();
          
        }
    }
}
