using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{
    interface prop
    {
        string Name
        {
            get;
            set;
        }
    }
    class property_in_interface : prop
    { 
        private string name = "charan";
       
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name  = value;
            }
        }
        
    }
}
