using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{


    interface arrayindex
    {
        object this[int index]
        {
            get;
           
        }
    }
    class indexers_with_arrays : arrayindex
    {

        object []obj = new object[10];
        private int id;
        private string name;
        private string place;
 
        public indexers_with_arrays(int id, string name, string place)
        {
            this.id = id;
            this.name = name;
            this.place = place;    
        }
        
        public object this[int index]
        {
  
            get
            {
                return obj[index];
            }
            
        }
        static void Main(string[] args)
        {
            object[] obj = new object[10];
            indexers_with_arrays indr = new indexers_with_arrays(301, "charan", "nellore");
            //obj[0] = indr;
            indexers_with_arrays a1 = (indexers_with_arrays)obj[0];
            Console.WriteLine(a1.id);
            Console.WriteLine(a1.name);
            Console.WriteLine(a1.place);
            Console.ReadKey();
        }
    }
}
