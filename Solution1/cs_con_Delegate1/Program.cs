using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static cs_con_Delegate1.TrafficSignal;
namespace cs_con_Delegate1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrafficSignal traffic = new TrafficSignal();
            TrafficDel trafficDelRed = new TrafficDel(traffic.show(["Red"]);
            TrafficDel trafficDelGreen = new TrafficDel(traffic.show());
            TrafficDel trafficDelYellow = new TrafficDel(traffic.show());
            Console.WriteLine("Welcome to the Traffic System !!!");
            Console.WriteLine();
            Console.WriteLine("Enter the color of Traffic Signal:");
            string a = Console.ReadLine();
            string OperationType = Console.ReadLine();
            if (OperationType == "Red")
            {
                Console.WriteLine($"{trafficDelRed}");
            }
            else if (OperationType == "Yellow")
            {

                Console.WriteLine($"{trafficDelYellow}");
            }
            else if (OperationType == "Green")
            {

                Console.WriteLine($"{trafficDelGreen}");
            }
        }
    }
}
