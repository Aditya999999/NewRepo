//Implicit and explicit conversion
namespace cs_con_TwelfthProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            //Implicit conversion
            int i = 43;
            long j = i;
            Console.WriteLine(j);


            // Explicit conversion
            double x = 999999.999;
            int a;
            // Cast double to int.
            a = (int)x;
            Console.WriteLine(a);

        }
    }
}