namespace cs_con_AsOperator
{
    // AS OPERATOR works only with Reference Types
    internal class Program
    {
        static void As()
        {
            Console.WriteLine("Hello, World!");
            student A = new student();
            A.name = "Aditya";
        
            A.Marks = 82.7M;
            A.EnrollmentNo = 8693F;

            Console.WriteLine($"{A.name}, {A.Marks}, {A.EnrollmentNo}");

            Adi objA = new Adi();
            objA.Name = "hello Aditya";

            object o = A;                        // boxing


            Adi? objB = o as Adi; // Unboxing using the AS operator (safe type-casting operator)
            
            if (objB == null)
            {
                Console.WriteLine("o is not a proper B type variable");
            }
            else
            {
                Console.WriteLine(objB.Name);
            }



        }
        public class student 
        {
            public string? name;
            public decimal Marks;
            public double EnrollmentNo;
        }
        class Adi
        {
            public string? Name;
        }
    }
}