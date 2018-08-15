using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class select
    {
        public static void Main()
        {
            
            IList<Student3> studentList = new List<Student3>() {
                new Student3() { StudentID = 1, StudentName = "John" } ,
                new Student3() { StudentID = 2, StudentName = "Moin" } ,
                new Student3() { StudentID = 3, StudentName = "Bill" } ,
                new Student3() { StudentID = 4, StudentName = "Ram" } ,
                new Student3() { StudentID = 5, StudentName = "Ron"  }
            };

            var selectResult = from s in studentList  select s.StudentName;

            foreach (var name in selectResult)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }

    public class Student3
    {

        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }
}
