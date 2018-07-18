using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{

    interface inf1
    {
         object this[int index]
        {
            get;
            set;
        }
    }
    class indexer_in_interface : inf1
    {
        private int id = 10564651;
        private string name = "saikumar";
        private string place = "banglore";
        public object this[int index]
        {
            get
            {
                if (index == 1)
                {
                    return id;
                }
                else if (index == 2)
                {
                    return name;
                }
                else if (index == 3)
                {
                    return place;
                }
                return Convert.ToInt32(null);
            }
            set
            {
                if (index == 1)
                {
                    id = (Convert.ToInt32(value));
                }
                else if (index == 2)
                {
                    name =(Convert.ToString(value));
                }
                else if (index == 3)
                {
                    place = (Convert.ToString(value));
                }
                
            }
        }
    }
}
