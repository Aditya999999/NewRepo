using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_GeometryApplicationInterface
{
    internal interface ITriangle
    {
        double area();
    }
    public class RightAngledTriangle : ITriangle
    {
        public int baseLength = 0;
        public int height = 0;

        public RightAngledTriangle(int baseLength, int height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }

        public double area()
        {
            return (int)(0.5 * baseLength * height);
        }

    }
}
