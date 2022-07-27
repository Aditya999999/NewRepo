using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_GeometryApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Rectangle A = new Rectangle(7,7);
            Console.WriteLine($"Area of Rectangle = {A.Area()} and Perimeter of Rectangle = {A.Perimeter()}");

            Square B = new Square(10);
            Console.WriteLine($"Area of Square = {B.Area()} and Perimeter of Square = {B.Perimeter()}");

            Console.WriteLine();
            RightAngledTriangle T = new RightAngledTriangle(6,7);
            Console.WriteLine($"Area of Triangle is: {T.area()}");

            Console.WriteLine();
            Circle C = new Circle(5);
            Console.WriteLine($"Area of Circle is: {C.Area()}");

            Console.WriteLine();
            Oval oval = new Oval(5,6);
            Console.WriteLine($"Area of oval is : {oval.Area()}");
        }

    }
}
