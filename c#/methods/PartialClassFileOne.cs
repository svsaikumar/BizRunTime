using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{


    public partial class SamplePartialClass
    {
        partial void SamplePartialMethod();

        public void PublicMethod()
        {
            Console.WriteLine("from public method");
            SamplePartialMethod();
        }
        
    }
}
