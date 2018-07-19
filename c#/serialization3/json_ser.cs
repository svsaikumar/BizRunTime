using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Runtime.Serialization;

using System.Runtime.Serialization.Json;

using System.IO;

namespace serialization3
{
    [DataContract]
    public class json_ser
    {
        [DataMember]
        public int id;
        [DataMember]
        public string name;
        [DataMember]
        public string place;

        public json_ser(int id, string name, string place)
        {
            this.id = id;
            this.name = name;
            this.place = place;
        }

        static void Main(string[] args)
        {
            json_ser e1 = new json_ser(1, "saikumar", "banglore");

            FileStream stream = new FileStream(@"S:\BizRuntime\training\c#\serial_files\employee_json.json", FileMode.OpenOrCreate);

            //serializes the object to JSON
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(json_ser));

            ser.WriteObject(stream, e1);

          
            StreamReader sr = new StreamReader(stream);
            string str = sr.ReadToEnd();
            Console.WriteLine("serialization done");

        
            Console.ReadKey();

        }
    }
}
