namespace cs_con_AnonymousFunction
{
    internal class Program
    {
        public delegate void student(string name, int RollNumber, int EnrollmentNumber, decimal Percentage);
        static void Main(string[] args)
        {

            student s = delegate (string name, int RollNumber, int EnrollmentNumber, decimal Percentage)
            {
                Console.WriteLine($"The name of student is - {name},\n Roll number of student is - {RollNumber},\n Enrollment number is - {EnrollmentNumber}, \nand his marks percentage is - {Percentage}!!!!");
            };
            s("Aditya Dubey", 07, 8693, 82.7M);
        }
    }
}