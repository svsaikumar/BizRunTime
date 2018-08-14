using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class person
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Class6
    {
        delegate bool IsTeenAger(person stud);

        static void Main(string[] args)
        {
           
            
            IsTeenAger isTeenAger = delegate (person s) 
                                        {
                                            return s.Age > 12 && s.Age < 20;
                                        };

            person per = new person() { Age = 25 };

            Console.WriteLine(isTeenAger(per));
            Console.ReadKey();


        }

    }
 }

