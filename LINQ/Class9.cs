using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Student1
    {

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

    }
    class Class9
    {
        static void Main(string[] args)
        {
            IList<Student1> studentList = new List<Student1>()
            {
                new Student1() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student1() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student1() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student1() { StudentID = 4, StudentName = "Ron" , Age = 17 } ,
                new Student1() { StudentID = 5, StudentName = "Ram" , Age = 19 }
            };
            var thenByResult = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age);
            foreach(var s in thenByResult)
            {
                Console.WriteLine("Name:{0} , Age :{1}", s.StudentName, s.Age);
            }
            Console.ReadKey();
        }
    }
}
