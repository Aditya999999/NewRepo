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

            Console.WriteLine("Welcome to the Traffic System !!!");
            Console.WriteLine();
            traffic.IdentifySignals();
            traffic.show();
            
        }
    }
}
