using System;
using System.Linq;
namespace cs_con_ArithmeticOperationLambda

{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Func<int , int, int> sum = (a, b) => a + b;
            Func<int, int, int> sub = (a, b) => a - b;
            Func<int, int, int> mul = (a, b) => a * b;
            Func<int, int, int> div = (a, b) => a / b;
            int a = 10;
            int b = 5;
            Console.WriteLine($"The two numbers are: {a} and {b}");
            Console.WriteLine($"The addition of two numbers is: {sum.Invoke(a,b)}");
            Console.WriteLine($"The substraction of two numbers is: {sub.Invoke(a, b)}");
            Console.WriteLine($"The multiplication of two numbers is: {mul.Invoke(a, b)}");
            Console.WriteLine($"The division of two numbers is: {div.Invoke(a, b)}");
        }
    }
}