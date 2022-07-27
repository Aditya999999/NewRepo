using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_GeometryApplicationInterface
{
    internal interface IRoundSymbols
    {
        double Area();
        double perimeter();
    }
    public class Circle : IRoundSymbols
    {
        public int radius = 0;
        public Circle(int n)
        {
            radius = n;
        }

        public double Area()
        {
            return 3.14 * (double)Math.Pow(2, radius);
        }
        public double perimeter()
        {
            return 2 * 3.14 * radius;
        }
    }
    public class Oval : IRoundSymbols
    {
        int radius = 0;
        int majorRadius = 0;
        public Oval(int x, int y)
        {
            radius = x;
            majorRadius = y;
        }


        public double Area()
        {
            return 3.14 * (radius / 2) * (majorRadius / 2);
        }
        public double perimeter()
        {
            return (3.14 * radius / 2) * (majorRadius / 2);
        }
    }
}
