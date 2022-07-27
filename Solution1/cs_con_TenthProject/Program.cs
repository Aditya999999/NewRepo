/*According to Gang of Four Definition “Define an interface for creating an object,
 * but let the subclasses decide which class to instantiate.
 * The Factory method lets a class defer instantiation it uses to subclasses”.
*/
namespace cs_con_TenthProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Aditya!");
            Console.WriteLine("Enter any number: ");
            string? number = Console.ReadLine();

            //Using Parse
            int num = 0;
            if (!string.IsNullOrEmpty(number))
            {
                num = int.Parse(number);
            }
            Console.WriteLine($"Converted {number} to {num}");

            // Using Try Parse
            {
                bool success = int.TryParse(number, out num);
                if (success)
                {
                    Console.WriteLine($"Converted '{num}' to {number}.");
                }
                else
                {
                    Console.WriteLine($"Attempted conversion of '{number ?? "<null>"}' failed.");
                }
            }
        }
    }
}