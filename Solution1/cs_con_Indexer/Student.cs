using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Indexer
{
    internal class Student
    {
        private string[] _studentNames;
        public Student()
        {
            _studentNames = new string[5] {
                "Aditya Dubey", 
                "Aman Mishra", 
                "Amit Tiwari", 
                "Saurabh Shukla", 
                "Shubham Singh"};
        }
        public string FirstName
        {
            get
            {
                return _studentNames[0];
            }
            set
            {
                _studentNames[0] = value;
            }
        }

        public string GetName(int Marks)
        {
            return _studentNames[Marks];
        }

        public void SetName(int Marks, string newname)
        {
            _studentNames[Marks] = newname;
        }

        public string this[int Marks]
        {
            get
            {
                return _studentNames[Marks];
            }
            set
            {
                _studentNames[Marks] = value;
            }
        }
        public void DisplayNames()
        {
            foreach (string name in _studentNames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }
    }
}
