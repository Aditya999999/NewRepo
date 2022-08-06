using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Delegate1
{
    public delegate void TrafficDel();
    internal class TrafficSignal
    {



        public string signal;
        public static void Yellow()
        {
            Console.WriteLine("Yellow Light Signal To Get Ready");
        }
        public static void Green()
        {
            Console.WriteLine("Green Light Signal To Go");
        }
        public static void Red()
        {
            Console.WriteLine("Red Light Signal To Stop");
        }
        TrafficDel[] traffics = new TrafficDel[3];

        public void IdentifySignals() 
        {
            traffics[0] = new TrafficDel(Yellow);
            traffics[1] = new TrafficDel(Green);
            traffics[2] = new TrafficDel(Red);

        }
        public void show()
        {
            traffics[0]();
            traffics[1]();
            traffics[2]();
        }
        
    }
}
