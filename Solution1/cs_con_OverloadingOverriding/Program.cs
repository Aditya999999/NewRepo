using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Interest interest = new Interest();
            interest.p = 10000;
            interest.r = 15;
            interest.t = 5;

            Console.WriteLine(interest.SimpleInterest(10000, 15, 5));

            BaseClass B = new BaseClass();
            Console.WriteLine("Difference is:" + B.Difference(50, 25));

        }

        // OverLoading
        public class Interest
        {
            public int p,r,t, x;
            
            public int SimpleInterest(int p, int r, int t)
            {
                return p * r * t / 100;
            }
            public int SimpleInterest(float p, float r, int t, int x)
            {
                return (int)((p * r * t * x) / 100);
            }
        }


        //OverRiding
        public class BaseClass
        { 
            public virtual int Difference(int num1, int num2)
            { 
                return num1 - num2; 
            }
        }

        public class ChildClass : BaseClass
        {
            public override int Difference(int num1, int num2)
            {
                Console.WriteLine("Values could not be less than zero or equals to zero");
                Console.WriteLine("Enter First value : ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter First value : ");
                num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 < 0 || num2 < 0)
                {
                    return num1 - num2;
                }
                else if ((num1 & num2) < 0)
                {
                    return num1 + num2;
                }
                else if (num1 < num2)
                {
                    return num2 - num1;
                }
                else
                {
                    return num1 - num2;
                }
            }
        }

    }
}
