using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace serialization3
{
    [Serializable]
    public class student
    {
        public int id;
        
        public string name;
        public string place;
        public student(int id, string name, string place)    
        {
            this.id = id;
            this.name = name;
            this.place = place;

        }
    }
    class binary_serialization_using_Serializable
    {
        static void Main(string[] args)
        {
            
            student s1 = new student(1,"saikumar", "banglore");
            Console.WriteLine(s1.id);
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.place);

            FileStream file = new FileStream(@"S:\BizRuntime\training\c#\serial_files\student.txt", FileMode.OpenOrCreate);
            BinaryFormatter format = new BinaryFormatter();
            format.Serialize(file, s1);
            file.Close();
            Console.ReadKey();
        }
    }
}
