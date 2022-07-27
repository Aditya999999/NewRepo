using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Destructor
{
    internal class Shape
    {
        public int SideNum { get; private set; }
        public string ShapeName { get; private set; }
        public Shape(int num, string Name)
        {
            SideNum = num;
            ShapeName = Name;
            Console.WriteLine($"Shape with side number {this.SideNum} is created");
        }
        ~Shape()
        {
            Console.WriteLine($"Shape with side number {this.SideNum} is destroyed");
        }
    }
}
