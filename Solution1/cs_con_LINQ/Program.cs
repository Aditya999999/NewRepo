using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>();
            student.Add(new Student() { Name = "Aditya Dubey", RollNo = 7});
            student.Add(new Student() { Name = "Saurabh Shukla" , RollNo = 43});
            student.Add(new Student() { Name = "Shubham Singh", RollNo = 51 });
            student.Add(new Student() { Name = "Abhishek Singh", RollNo = 4 });
            student.Add(new Student() { Name = "Abiran Rathaur", RollNo = 6 });
            student.Add(new Student() { Name = "Adbhit Kumar", RollNo = 5 });
            student.Add(new Student() { Name = "Anumpam Verma", RollNo = 12 });
            student.Add(new Student() { Name = "Aman Mishra", RollNo = 11 });
            student.Add(new Student() { Name = "Amit Tiwari", RollNo = 10});

            Console.WriteLine("List of the students in the collection");
            foreach (Student s in student)
            {
                Console.WriteLine("{0} {1}", s.RollNo, s.Name);
            }
            Console.WriteLine();
            var query = from s in student
                        orderby s.Name
                        select s;
            Console.WriteLine("List of the students in the collection - After Sorting using LINQ");
            foreach (Student s in query)
            {
                Console.WriteLine("{0}  {1, -20}", s.RollNo, s.Name);
            }
            Console.WriteLine();
        }
    }
}
