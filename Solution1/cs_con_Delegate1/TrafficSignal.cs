using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Delegate1
{
    internal class TrafficSignal
    {
        private string signal;
        private string yellow;
        private string red;
        private string green;

        public delegate void TrafficDel();
        
        public void Yellow()
        {
            Console.WriteLine("Yellow Light Signal To Get Ready");
        }
        public void Green()
        {
            Console.WriteLine(" Green Light Signal To Go");
        }
        public void Red()
        {
            Console.WriteLine("Red Light Signal To Stop");
        }

        public static void IdentifySignals() 
        {
            string[] signal = new string[3] { "Red", "Yellow", "Green" };

        }
        public void show(string[] signal)
        {
            if (bool.Parse(signal[0]))
            {
                Console.WriteLine("Please Stop!!!");
            }
            else if (bool.Parse(signal[1]))
            {
                Console.WriteLine("Be ready!!!");
            }
            else if (bool.Parse(signal[2]))
            {
                Console.WriteLine("You can Move!!!!");
            }
            else
            {
                Console.WriteLine("This color does not exist in Traffic System.");
            }

        }
    }
}
