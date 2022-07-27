using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Interface
{
    internal interface IUserInput
    {
        void showUserName();
    }
    public class UserName: IUserInput
        {

        public string Name;
        public UserName(string A)
        {
            Name = A;
        }
        public void showUserName()
        {
            Console.Write("Enter your Name: ");
            string InputName = Console.ReadLine();
            Console.WriteLine($"Hi {InputName}");

            string upperName = InputName.ToUpper();
            Console.WriteLine($"Hi {upperName}");
        }
    }
}
