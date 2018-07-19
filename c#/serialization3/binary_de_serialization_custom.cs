using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace serialization3
{
    class binary_deserialization_custom
    {

        static void Main(string[] args)
        {
            FileStream file = File.OpenRead(@"S:\BizRuntime\training\c#\serial_files\student1.txt");
            BinaryFormatter format = new BinaryFormatter();


            student1 ds1 = (student1)format.Deserialize(file);

            //Console.WriteLine("id is:" + ds1._id);
            Console.WriteLine("name is :" + ds1._name);
            Console.WriteLine("place is :" + ds1._place);
            Console.ReadKey();

        }
    }
}
