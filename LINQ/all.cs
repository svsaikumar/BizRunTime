using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class all
    {
        public static void Main()
        {
            IList<Student4> studentList = new List<Student4>() {
            new Student4() { StudentID = 1, StudentName = "John", Age = 13 } ,
            new Student4() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            new Student4() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student4() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            new Student4() { StudentID = 5, StudentName = "Ron" , Age = 15 }
        };

             
            bool areAllStudentsTeenAger = studentList.All(s => s.Age > 12 && s.Age < 20);


            Console.WriteLine(areAllStudentsTeenAger);
            Console.ReadKey();
        }
    }

    public class Student4
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}
