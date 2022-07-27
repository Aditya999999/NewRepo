using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_GeometryApplicationInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle R1 = new Rectangle(7,8);
            Console.WriteLine($"The perimeter of Rectangle is : {R1.Perimeter()} and Area is : {R1.Area()}");

            Console.WriteLine();

            Square S = new Square(5);
            Console.WriteLine($"The perimeter of Square is : {S.Perimeter()} & the Area is :{S.Area()}");

            Console.WriteLine();


            RightAngledTriangle T = new RightAngledTriangle(6, 7);
            Console.WriteLine($"Area of Triangle is: {T.area()}");

            Circle C = new Circle(5);
            Console.WriteLine($"Area of Circle is: {C.Area()}");

            Oval oval = new Oval(5, 6);
            Console.WriteLine($"Area of oval is : {oval.Area()}");
        }
    }
}
