using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Aggregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            Car Tata = new Car(Convert.ToString("FourWheeler"));
            //Tata.Car1("Tata");

        }
        public class Vehicle
        { 
            private string v;
             
        }
        public class Car
        { 
            private Vehicle vehicle;
            private string v;

            public Car(Vehicle vehicle)
            {
                this.vehicle = vehicle;
            }

            public Car(string v)
            {
                this.v = v;
                Console.WriteLine(v);
            }

        }
    }
}
