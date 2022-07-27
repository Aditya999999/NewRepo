namespace cs_con_FifthProject
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

            // function check whether a number
            // is prime or not
            static bool isPrime(int num, int i = 2)
            {

                // corner cases
                if (num == 0 || num == 1)
                {
                    return false;
                }

                // Checking Prime
                if (num == i)
                    return true;

                // base cases
                if (num % i == 0)
                {
                    return false;
                }
                i++;
                return isPrime(num, i);
            }
            if (isPrime(num))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}