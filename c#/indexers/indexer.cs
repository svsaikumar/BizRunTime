using System;
using System.Collections.Generic;
using System.Text;

namespace indexers
{


    class student
    {
        int id;
        string name;
        double salary;
        string location;
        public student(int id, string name, double salary, string location)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.location = location;
        }


        public object this[int index]
        {
            get
            {
                if (index == 1)
                    return id;
                else if (index == 2)
                    return name;
                else if (index == 3)
                    return salary;
                else if (index == 4)
                    return location;
                return null;
            }

            set
            {
                if (index == 1)
                    id = (int)value;
                else if (index == 2)
                    name = (string)value;
                else if (index == 3)
                    salary = (double)value;
                else if (index == 4)
                    location = (string)value;
            }
        }

    }
    class indexer
    {
        static void Main(string[] args)
        {
            student s = new student(101, "saikumar", 20000, "banglore");
            Console.WriteLine("student id:" + s[1]);
            Console.WriteLine("student id:" + s[2]);
            Console.WriteLine("student id:" + s[3]);
            Console.WriteLine("student id:" + s[4]);
            Console.WriteLine("===========================");
            s[1] = 201;
            s[2] = "arjun";
            s[3] = 3000.0;
            s[4] = "hyderabad";

            Console.WriteLine("student id:" + s[1]);
            Console.WriteLine("student id:" + s[2]);
            Console.WriteLine("student id:" + s[3]);
            Console.WriteLine("student id:" + s[4]);

            Console.ReadKey();
        }
    }
}
