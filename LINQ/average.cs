using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class average
    {
        public static void Main()
        {
            IList<Student6> studentList = new List<Student6>() {
            new Student6() { StudentID = 1, StudentName = "John", Age = 13 } ,
            new Student6() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            new Student6() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student6() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            new Student6() { StudentID = 5, StudentName = "Ron" , Age = 15 }
        };

        var avgAge = studentList.Average(s => s.Age);

         Console.WriteLine("Average Age of Student: {0}", avgAge);
         Console.ReadKey();
        }
    }
    public class Student6
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}
