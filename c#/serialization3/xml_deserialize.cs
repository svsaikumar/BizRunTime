using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace serialization3
{
    class xml_deserialize
    {
        static void Main(string[] args)
        {
            XmlSerializer xml = new XmlSerializer(typeof(employee));
            StreamReader sr = new StreamReader(@"S:\BizRuntime\training\c#\serial_files\employee.xml");
            employee emp = (employee)xml.Deserialize(sr);
            Console.WriteLine("employee id:" + emp.id);
            Console.WriteLine("employee name:" + emp.name);
            Console.WriteLine("employee place:" + emp.place);
            Console.ReadKey();
        }
    }
}
