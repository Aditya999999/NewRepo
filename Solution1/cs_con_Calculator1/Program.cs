using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Calculator1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                add a1 = new add();
                Console.WriteLine("Enter 1st number:");
                string a = Console.ReadLine();
                int A = int.Parse(a);
                Console.WriteLine("Enter 2nd number:");
                string b = Console.ReadLine();
                int B = int.Parse(b);
                Console.WriteLine("Enter the Operaion: \n" +
                                  "Press 1. For Addition \n" +
                                  "Press 2. for Subtraction \n" +
                                  "Press 3. for multiplication \n" +
                                  "Press 4. for division");
                string OperationType = Console.ReadLine();
                if (OperationType == "1")
                {
                    Console.WriteLine($"Addition is : {a1.sumof(A, B)}");
                }
                else if (OperationType == "2")
                {
                    Subtract sub = new Subtract();
                    Console.WriteLine($"Substraction is : {sub.subof(A, B)}");
                }
                else if (OperationType == "3")
                {
                    product mult = new product();
                    Console.WriteLine($"Multiplication is : {mult.multof(A, B)}");
                }
                else if (OperationType == "4")
                {
                    division div = new division();
                    Console.WriteLine($"Division is : {div.divof(A, B)}");
                }
                else 
                {
                    Console.WriteLine("Wrong Operation");
                }
            }
        }
    }
}
