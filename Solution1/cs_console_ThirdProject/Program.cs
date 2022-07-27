namespace cs_console_ThirdProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Enter your name - ");
            string? name = Console.ReadLine();
            DateTime aDate = DateTime.Now;

            //Name and datetime
            Console.WriteLine("Hi" + name + ". Today is " + aDate);

            //String Length
            int stringLength = name.Length;
            Console.WriteLine("Your name have " + stringLength + " characters");

            //empty string
            Console.Write("Enter your SiblingNumbers : ");
            string? siblingInput = Console.ReadLine();
            int siblingNumber = 0;
            if (!string.IsNullOrEmpty(siblingInput)) 
            { 
                siblingNumber = int.Parse(siblingInput);
            }
            Console.WriteLine($"Hi {name}. You have {siblingNumber} siblings!");

            //Parsing string into integer
            Console.WriteLine("Enter your family member numbers: ");
            string? numFamilymembers = Console.ReadLine();
            int memNum = -1;
            if (!string.IsNullOrEmpty(numFamilymembers))
            {
                memNum = Convert.ToInt32(numFamilymembers);
            }
            Console.WriteLine("You have "+ memNum + " Family members in your family.");
            


        }
    }
}