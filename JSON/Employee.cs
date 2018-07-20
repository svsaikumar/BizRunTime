using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToCObject
{
    class Employee
    {
      
        public int id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string city
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        public Employee(int id, string name, string city)
        {
            this.id = id;
            this.name = name;
            this.city = city;
        }

    }
}
