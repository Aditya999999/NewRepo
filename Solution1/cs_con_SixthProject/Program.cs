
namespace cs_con_SixthProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            myStruct a;
            
            a.x = 100;
            a.y = 200;
            Console.WriteLine($"{a.x},{a.y}");

            myClass C1 = new myClass();
            C1.EmpName = "Aditya Dubey";
            C1.age = 22;
            C1.Empid = 154337;
            Console.WriteLine(C1.Empid);
            Console.WriteLine(C1.age);
            Console.WriteLine(C1.EmpName);
        }

}

}