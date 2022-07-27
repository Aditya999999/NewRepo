using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_StaticConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aditya adi = new Aditya(22);
            adi.setAge(22);
           
            Console.WriteLine("The age of Aditya is: {0}", adi.getAge());

        }
        public class Aditya
        {
            public static int age;

            static Aditya()
            {
                Console.WriteLine("This is static constructor.");
            }
            public void setAge(int A)
            {
                age = A;
            }
            public int getAge()
            {
                return age;
            }


            public Aditya(int A)
            {
                Console.WriteLine("This is instance constructor.");
                age = A;
            }
        }
    }
}
