using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_LINQ
{
    internal class Student : System.IComparable
    {
        public int RollNo { get; set; }
        public string Name { get; set; }

        public int CompareTo(object obj)
        {
            Student stud = obj as Student;
            return this.RollNo.CompareTo(stud.RollNo);
        }
    }
}
