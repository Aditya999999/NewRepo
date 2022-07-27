using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_InterfaceExplicit.Demo
{
    interface IName
    {
        void name();
    }
    interface IName1 : IName
    {
        void UpperName();
    }
    class Aditya : IName1, IName
    {
        void IName.name()
        {
            Console.Write("Enter your Name: ");
            string InputName = Console.ReadLine();
            Console.WriteLine($"Hi {InputName}");

        }
        void IName1.UpperName()
        {
            Console.Write("Enter your Name: ");
            string InputName = Console.ReadLine();
            

            string upperName = InputName.ToUpper();
            Console.WriteLine($"HELLO {upperName}");
        }

    
    }
    class ShowNames 
    {
        public static void Show()
        {
            Aditya obj = new Aditya ();
            //(obj as IName).name();
            (obj as IName1).UpperName();
            Console.WriteLine();

            IName1 obj2 = new Aditya();
            obj2.UpperName();
          
        }
    }
}
