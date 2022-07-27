using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Calculator1
{
    class Operations
    {


    }
    class add : Operations
    {
        public int sumof(int a, int b)
        {
            return a + b;

        }
    }
    class Subtract : Operations
    {
        public int subof(int a, int b)
        {
            return a - b;

        }
    }
    class product : Operations
    {
        public int multof(int a, int b)
        {
            return (a * b);
        }
    }

    class division : Operations
    {
        public int divof(int a, int b)
        {
            return (a / b);
        }
    }
}
