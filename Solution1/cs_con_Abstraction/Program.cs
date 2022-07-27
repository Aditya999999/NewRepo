using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aditya N = new Aditya();
            Male thePerson = N;      //Boxing

            N.Name();
            thePerson.Name();

        }
        abstract class Male
        {
            public abstract void Name();
        }
        class Aditya : Male
        {
            public override void Name()
            {
                Console.WriteLine("My name is Aditya Dubey");
            }
        }
    }
}
