using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static cs_con_CalculatorDelegate.Operation;

namespace cs_con_CalculatorDelegate
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Operation opr = new Operation();
            addnum obj1 = new addnum(opr.Addition);
            subnum obj2 = new subnum(opr.Substraction);
            mulnum obj3 = new mulnum(opr.Multipilication);
            divnum obj4 = new divnum(opr.Division);
            //Console.WriteLine($"Addition is: {obj1(100, 40)}");
            //Console.WriteLine($"Substraction is:{obj2(100, 60)}");
            //Console.WriteLine($"Multiplication is: {obj3(100, 40)}");
            //Console.WriteLine($"Division is: {obj4(100, 60)}");
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
                Console.WriteLine($"Addition is : {obj1(A, B)}");
            }
            else if (OperationType == "2")
            {
                
                Console.WriteLine($"Substraction is : {obj2(A, B)}");
            }
            else if (OperationType == "3")
            {
               
                Console.WriteLine($"Multiplication is : {obj3(A, B)}");
            }
            else if (OperationType == "4")
            {
                
                Console.WriteLine($"Division is : {obj4(A, B)}");
            }
            else
            {
                Console.WriteLine("Wrong Operation");
            }
        }
    }
}
