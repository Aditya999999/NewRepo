using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Volume C = new Volume();
            C.setLength(4);
            Console.WriteLine($"The volume of Cube is: {C.getVol()}");
        }
        class Cube
        {
            public void setLength(int l) {
                length = l;
            }
            protected int length;
        }
        class Volume : Cube 
        {
            public int getVol() 
            {
                return (length * length * length);
            }
        }
    }
}
