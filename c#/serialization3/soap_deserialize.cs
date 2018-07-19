using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace serialization3
{
    class soap_deserialize
    {
        static void Main(string[] args)
        {
            SoapFormatter sf = new SoapFormatter();
            FileStream fs = new FileStream(@"S:\BizRuntime\training\c#\serial_files\person.xml", FileMode.Open);
            person p2 = (person)sf.Deserialize(fs);
            Console.WriteLine("soap deserialization");
            Console.WriteLine(p2.id);
            Console.WriteLine(p2.name);
            Console.WriteLine(p2.place);
            Console.ReadKey();
        }
    }
}
