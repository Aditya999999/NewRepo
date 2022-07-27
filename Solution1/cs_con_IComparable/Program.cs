using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_IComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
            {
                new Student(){
                    studID = 1,
                    Name = "Aditya Dubey"
                },
                new Student(){
                    studID= 4,
                    Name = "Saurabh Shukla"
                    },
                new Student(){
                    studID = 3,
                    Name = "Amit Tiwari"
                },
                new Student(){
                    studID = 2,
                    Name = "Aman Mishra"
                }
            };
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.studID} {student.Name}");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");


            //  ARRAYS SORTING BUILT-IN FUNCTION
            Array.Sort(students);

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.studID}... {student.Name}");
            }
            Console.WriteLine();

            /*foreach (Student1 student1 in students)
            {
                Console.WriteLine($"{student1.studID}... {student1.Name}");
            }
            Console.WriteLine();
            */
        }
    }
}
