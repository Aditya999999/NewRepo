//Pass by value, reference and out and calculating square root.

namespace cs_con_NinthProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            
            //Pass By Value
            Console.WriteLine("Pass by Value");
            i = 9;
            Console.WriteLine($"Before: i = {i}");
            PassByValue(i);
            Console.WriteLine($"After: i = {i}");
            Console.WriteLine();

            //Pass By Reference
            Console.WriteLine("Pass by Reference");
            i = 16;                  
            Console.WriteLine($"Before: i = {i}");
            PassByReference(ref i);
            Console.WriteLine($"After: i = {i}");
            Console.WriteLine();

            //Pass by Out 
            i = 25;               
            Console.WriteLine($"Before: i = {i}");
            Console.WriteLine("Square root is: {0}", Math.Sqrt(i));
            PassByOut(out i);
            Console.WriteLine($"After: i = {i}");
            Console.WriteLine("Square root is: {0}", Math.Sqrt(i));
            Console.WriteLine();


            static void PassByValue(int x)
            {
                Console.WriteLine($"received x = {x}");
                Console.WriteLine("Square root is: {0}", Math.Sqrt(x));
                x = 15;
                Console.WriteLine($"after changing, x = {x}");
                Console.WriteLine("Square root is: {0}", Math.Sqrt(x));
            }
            static void PassByReference(ref int x)
            {
                Console.WriteLine($"received x = {x}");
                Console.WriteLine("Square root is: {0}", Math.Sqrt(x));
                x = 25;
                Console.WriteLine($"after changing, x = {x}");
                Console.WriteLine("Square root is: {0}", Math.Sqrt(x));
            }
            static void PassByOut(out int x)
            {
                x = 36;     
                Console.WriteLine($"after initializing, x = {x}");
                Console.WriteLine("Square root is: {0}", Math.Sqrt(x));
            } 

        }
    }
}