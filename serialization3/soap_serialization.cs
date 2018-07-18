using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace serialization3
{

    [Serializable]
    class person
    {
        public int id;
        public string name;
        public string place;

        public person(int id, string name, string place)
        {
            this.id = id;
            this.name = name;
            this.place = place;
        }
    }
    class soap_serialization
    {
        static void Main(string[] args)
        {
            SoapFormatter sf = new SoapFormatter();
            FileStream fs = new FileStream(@"S:\BizRuntime\training\c#\serial_files\person.xml", FileMode.OpenOrCreate);
            person p = new person(401, "charan", "nellore");
            sf.Serialize(fs, p);
            Console.WriteLine("soap serialization success");
            Console.ReadKey();

        }
    }
}
