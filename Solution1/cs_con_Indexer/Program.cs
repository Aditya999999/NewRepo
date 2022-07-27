using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Marks = new int[5] { 55, 65, 75, 85, 95 };
            int secondItem = Marks[1];            // GET Accessor of the Indexer
            Marks[3] = secondItem + 10;           // SET Accessor of the Indexer


        
        Student student = new Student();
            student.DisplayNames();

            student.FirstName = student.FirstName.ToUpper();         // Property

            student.SetName(1, student.GetName(1).ToUpper());           // Method
            student.DisplayNames();

            student[2] = student[2].ToUpper();                          // Indexer
            student.DisplayNames();
        }
    }
}
