using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Destructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape S1;           // Declare
            Shape S2 = null;    // Declare & Instantiate

            Shape S3 = new Shape(3, "Triangle");
            S3 = null;

            method();
            Shape S4 = new Shape(4, "Quadrilateral");


            Console.WriteLine();
            Console.WriteLine("****** On exiting the Main()");
        }

        static void method()
        {
            Shape S5 = new Shape(5, "Pentagon");

            Shape[] ShapeArr = new Shape[3];
            ShapeArr[0] = new Shape(6, "Hexagon");

        }
    }
    }

