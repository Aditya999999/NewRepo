using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_GeometryApplication
{
    public abstract class GeometricSymbols
    {
        public abstract int Area();

        public abstract int Perimeter();
    }   

        public class Rectangle : GeometricSymbols
        {
            public int length = 0;
            public int breadth = 0;
            
        public Rectangle(int l, int b)
        {
            length = l;
            breadth = b;
        }

        public override int Area()
        {
            return length * breadth;
        }

        public override int Perimeter()
        {
            return (length + breadth) * 2;
        }
    }
        public class Square : GeometricSymbols
        {
        public int length = 0;
        public Square(int l)
        {
           length = l;
        }

        public override int Perimeter()
            {
                return  4 * length;
            }
            public override int Area()
            {
                return length * length;
            }
    }
    }
