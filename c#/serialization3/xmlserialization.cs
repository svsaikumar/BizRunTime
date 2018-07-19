using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace serialization3
{
    [XmlRoot("employee")]
    public class employee
    {
        [XmlElement("id")]
        public int id;
        [XmlElement("name")]
        public string name;
        [XmlElement("place")]
        public string place;

        public employee()
        {

        }

        public employee(int id, string name, string place)
        {
            this.id = id;
            this.name = name;
            this.place = place;
        }

    }
    class xmlserialization
    {
        static void Main(string[] args)
        {
            try
            {
                employee e1 = new employee(301, "sekhar", "chennai");
                XmlSerializer xml = new XmlSerializer(typeof(employee));//it need type of object to serialize
                StreamWriter sw = new StreamWriter(@"S:\BizRuntime\training\c#\serial_files\employee.xml");
                xml.Serialize(sw, e1);
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
