using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleInterest SI = new SimpleInterest();
            SI.ArgumentValues();
            SI.Display();
            SI.GetSI();

        }
        class SimpleInterest {
            private int principalAmount;
            private int rate;
            private int time;

            public void ArgumentValues() {
                Console.Write("Enter principalAmount: ");
                principalAmount = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter rate: ");
                rate = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the TimePeriod: ");
                time = Convert.ToInt32(Console.ReadLine());
            }
            public double GetSI()
            {
                return principalAmount * rate * time / 100;
            }
            public void Display()
            {
                Console.WriteLine($"Principal Amount: {principalAmount}");
                Console.WriteLine($"Rate: {rate}");
                Console.WriteLine($"Time: {time}");
                Console.WriteLine($"SI : {GetSI()}");

            }
        }

    }
}
