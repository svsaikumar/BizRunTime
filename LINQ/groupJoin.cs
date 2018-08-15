using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class groupJoin
    {
        public static void Main()
        {
            // Student collection
            IList<Student2> studentList = new List<Student2>() {
                new Student2() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
                new Student2() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
                new Student2() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
                new Student2() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
                new Student2() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            };

            IList<Standard> standardList = new List<Standard>() {
                new Standard(){ StandardID = 1, StandardName="Standard 1"},
                new Standard(){ StandardID = 2, StandardName="Standard 2"},
                new Standard(){ StandardID = 3, StandardName="Standard 3"}
            };

            var groupJoin = standardList.GroupJoin(studentList,  
                                    std => std.StandardID,  
                                    s => s.StandardID,    
                                    (std, studentsGroup) => new  
                                {
                                        Students = studentsGroup,
                                        StandarFulldName = std.StandardName
                                    });

            foreach (var item in groupJoin)
            {
                Console.WriteLine(item.StandarFulldName);

                foreach (var stud in item.Students)
                    Console.WriteLine(stud.StudentName);
            }
            Console.ReadKey();

        }

    }

    public class Student2
    {

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int StandardID { get; set; }
    }

    public class Standard
    {

        public int StandardID { get; set; }
        public string StandardName { get; set; }
    }
}
