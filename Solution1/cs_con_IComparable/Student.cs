using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_IComparable
{
    internal class Student : System.IComparable
    {
        public int studID { get; set; }
        public string Name { get; set; }

        public int CompareTo(object stud)
        {
            Student student = (Student)stud;
            //for Ascending order
            return studID.CompareTo(student.studID);


        }
    }
    /*class Student1 : Student
    {
        public new int CompareTo(object stud1)
        {
            Student1 student1 = (Student1)stud1;
            //for Descending order
            return student1.studID.CompareTo(this.studID);

        }
    }
    */
}
