namespace cs_console_FourthProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Enter the number: ");
            string? number = Console.ReadLine();
            int num = 0;
            if (!string.IsNullOrEmpty(number))
            {
                num = int.Parse(number);
            }
            Console.WriteLine("You have entered " + num + ".");
            if (num % 2 == 0)
            {
                Console.WriteLine("Given number is even number.");
            }
            else {
                Console.WriteLine("Given number is odd number.");
            }
        }
    }
}