using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_ParametrizedConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition A = new Addition(10, 10);
            Addition B = new Addition(20, 20, 30);
            Console.WriteLine($"Object is being created, X = {A.getX()}, Y = {A.getY()},  Addition = {A.getAddition()}");
            Console.WriteLine($"Object is being created, X = {A.getX()}, Y = {A.getY()}, Z = {A.getZ()}, Addition = {A.getAddition1()}");
            A.setX(85);
            A.setY(100);
            A.setZ(150);

            Console.WriteLine($"Updated , X = {A.getX()}, Y = {A.getY()}, Addition = {A.getAddition()}");
            Console.WriteLine($"Updated , X = {A.getX()}, Y = {A.getY()}, Z= {A.getZ()} Addition = {A.getAddition1()}");
        }
        class Addition
        {
            private int X;
            public int Y;
            public int Z;
            public Addition(int l, int b) // Parametrized Constructor
            {
                Console.WriteLine("Object is being created, X = {0} and Y = {1}", l, b);
                X = l;
                Y = b;
            }
            public Addition(int l, int b, int h) // Parametrized Constructor
            {
                Console.WriteLine("Object is being created, X = {0} and Y = {1} and Z = {2}", l, b, h);
                X = l;
                Y = b;
                Z = h;
            }
            public void setX(int l)
            { 
                X = l;
            }
            public void setY(int b)
            { 
                Y = b;
            }
            public void setZ(int h)
            { 
                Z = h;
            }
            public int getX()
            { 
                return X;
            }
            public int getY()
            { 
                return Y;
            }
            public int getZ()
            { 
                return Z;
            }
            public int getAddition()
            {
                return X + Y;
            }
            public int getAddition1()
            {
                return X + Y + Z;
            }
        }

    }
}
