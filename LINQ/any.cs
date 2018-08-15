using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class any
    {
        public static void Main()
        {
            IList<Student5> studentList = new List<Student5>()
            {
                new Student5() { StudentID = 1, StudentName = "John", Age = 13 } ,
                new Student5() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student5() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student5() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student5() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

           
            bool isAnyStudentTeenAger = studentList.Any(s => s.Age > 12 && s.Age < 20);
            Console.WriteLine(isAnyStudentTeenAger);
            Console.ReadKey();
        }
    }
    public class Student5
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}
