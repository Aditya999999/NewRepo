using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_CalculatorDelegate
{
    internal class Operation
    {
        public int a, b;
        public delegate int addnum(int a, int b);
        public delegate int subnum(int a, int b);
        public delegate int mulnum(int a, int b);
        public delegate int divnum(int a, int b);
        public int Addition(int a, int b)
        { 
            return a + b;
        }
        public int Substraction(int a , int b)
        { 
            return a - b;
        }
        public int Multipilication(int a, int b)
        {
            return a * b;
        }
        public int Division(int a, int b)
        { 
            return a / b;
        }
    }
}
