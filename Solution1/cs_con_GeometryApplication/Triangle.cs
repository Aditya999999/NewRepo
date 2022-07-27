using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_GeometryApplication
{
    public abstract class Triangle
    {
        public abstract double area();
    }
    public class RightAngledTriangle : Triangle
    { 
        public int baseLength = 0;
        public int height = 0;

        public RightAngledTriangle(int baseLength, int height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }

        public override double area()
        {
            return (int)(0.5 * baseLength * height);
        }
    }
}
