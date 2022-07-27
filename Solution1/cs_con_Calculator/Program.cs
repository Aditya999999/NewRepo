using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of Input1: ");
            int input1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the value of Input2: ");
            int input2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the name of operation you want to perform: ");
            string OperationType = Console.ReadLine();

            if (OperationType == "Addition")
            {
                Addition A = new Addition(input1, input2, OperationType);
                Console.WriteLine($"Addition is : {A.CalAddition(input1, input2)}");
            }
            else if (OperationType == "Substraction")
            {

                Subtraction S = new Subtraction(input1, input2, OperationType);
                Console.WriteLine($"Subtraction is : {S.CalSubstraction(input1, input2)}");
            }

            else if (OperationType == "Multiplication")
            {

                Multiplication C = new Multiplication(input1, input2, OperationType);
                Console.WriteLine($"Multiplication is : {C.CalMultiplication(input1, input2)}");
            }
            else if (OperationType == "Division")
            {
                Division D = new Division(input1, input2, OperationType);
                Console.WriteLine($"Division is : {D.CalDivision(input1, input2)}");
            }
            else {
                Console.WriteLine("Wrong input");
            }
            }
    }
}
