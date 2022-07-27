using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_GeometryApplication
{
    public abstract class RoundSymbols
    {
        public abstract double Area();
        public abstract double perimeter();
    }
    public class Circle : RoundSymbols
    {
        public int radius = 0;
        public Circle(int n)
        {
            radius = n;
        }

        public override double Area()
        { 
            return 3.14 * (double)Math.Pow(2,radius);
        }
        public override double perimeter()
        {
            return 2 * 3.14 * radius;
        }
    }
    public class Oval : RoundSymbols
    {
        int radius=0;
        int majorRadius=0;
        public Oval(int x, int y)        {
            radius = x;
            majorRadius = y;
        }


        public override double Area()
        {
            return 3.14 * (radius / 2) * (majorRadius / 2);
        }
        public override double perimeter()
        {
            return (3.14 * radius / 2) * (majorRadius / 2);
        }
    }
}
