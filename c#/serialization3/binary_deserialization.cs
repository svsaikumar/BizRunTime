using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace serialization3
{

    class binary_deserialization
    {

        static void Main(string[] args)
        {

            FileStream file = File.OpenRead(@"S:\BizRuntime\training\c#\serial_files\student.txt");
            BinaryFormatter format = new BinaryFormatter();


            student ds = (student)format.Deserialize(file);

            Console.WriteLine("id is:" + ds.id);
            Console.WriteLine("name is :" + ds.name);
            Console.WriteLine("place is :" + ds.place);
            Console.ReadKey();

        }
    }
}
