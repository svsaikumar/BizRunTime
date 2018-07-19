using System;
using System.Collections.Generic;
using System.Text;

namespace indexers
{

    
    sealed class employee
    {
        private int id;
        string name;
        double salary;
        string location;
        public employee(int id, string name, double salary, string location)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.location = location;
        }

        public object this[string property]
        {
            get
            {
                if(property == "id")
                    return id;
                else if (property == "name")
                    return name;
                else if (property == "salary")
                    return salary;
                else if (property == "location")
                    return location;
                return null;
            }

            set
            {
                if (property == "id")
                    id = (int)value;
                else if (property == "name")
                    name = (string)value;
                else if (property == "salary")
                    salary = (double)value;
                else if (property == "location")
                    location = (string)value;
            }
        }

    }
    class indexer2
    {
        static void Main(string[] args)
        {
           
            employee e = new employee(101, "saikumar", 20000, "banglore");
            Console.WriteLine("employee id:" + e["id"]);
            Console.WriteLine("employee name:" + e["name"]);
            Console.WriteLine("employee salary:" + e["salary"]);
            Console.WriteLine("employee location:" + e["location"]);

            Console.WriteLine("===========================");

            e["id"] = 201;
            e["name"] = "arjun";
            e["salary"] = 3000.0;
            e["location"] = "hyderabad";

            Console.WriteLine("employee id:" + e["id"]);
            Console.WriteLine("employee id:" + e["name"]);
            Console.WriteLine("employee id:" + e["salary"]);
            Console.WriteLine("employee id:" + e["location"]);

            Console.ReadKey();
        }
    }
}
