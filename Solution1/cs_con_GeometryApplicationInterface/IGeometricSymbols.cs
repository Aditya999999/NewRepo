using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_GeometryApplicationInterface
{
    internal interface IGeometricSymbols
    {
        int Area();

        int Perimeter();
    }
    public class Rectangle : IGeometricSymbols
    {
        public int length = 0;
        public int breadth = 0;

        public Rectangle(int l, int b)
        {
            length = l;
            breadth = b;
        }

        public int Area()
        {
            return length * breadth;
        }

        public int Perimeter()
        {
            return (length + breadth) * 2;
        }
    }
    public class Square : IGeometricSymbols
    {
        public int length = 0;
        public Square(int l)
        {
            length = l;
        }

        public int Perimeter()
        {
            return 4 * length;
        }
        public int Area()
        {
            return length * length;
        }
    }
}
