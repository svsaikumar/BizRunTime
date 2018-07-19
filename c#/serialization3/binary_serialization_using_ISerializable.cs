using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace serialization3
{
    [Serializable]
    public class student1 : ISerializable
    {
        public int id;
        public string name;
        public string place;
        public int _id;
        public string _name;
        public string _place;
        public student1(int id, string name, string place)
        {
            this.id = id;
            this.name = name;
            this.place = place;

        }
        public student1(SerializationInfo info, StreamingContext context)
        {
            _id = Convert.ToInt16(info.GetValue("id1", typeof(int)));
            _name = Convert.ToString(info.GetValue("name1", typeof(string)));
            _place = Convert.ToString(info.GetValue("place1", typeof(string)));

        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("id1", id, typeof(int));
            info.AddValue("name1", name, typeof(string));
            info.AddValue("place1", place, typeof(string));
        }
    }
    class binary_serialization_using_ISerializable
    {

        static void Main(string[] args)
        {
            student1 s1 = new student1(201, "arjun", "hyderabad");
            Console.WriteLine(s1.id);
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.place);

            FileStream file = new FileStream(@"S:\BizRuntime\training\c#\serial_files\student1.txt", FileMode.OpenOrCreate);
            BinaryFormatter format = new BinaryFormatter();
            format.Serialize(file, s1);
            file.Close();


            Console.ReadKey();

        }
    }
}
