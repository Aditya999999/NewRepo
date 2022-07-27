using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Generic
{
    public class Animal<T>
    {
        public T Value { get; set; }
        public T Name { get; set; }

        public T Eats { get; set; }

        public void breed()
        {
            Console.WriteLine($"breed() called for the value = {this.Value} is {this.Name}");
        }
        public void eats()
        {
            Console.WriteLine($"eats() called for the value = {this.Value} and it eats {this.Eats}");
        }
    }
}
