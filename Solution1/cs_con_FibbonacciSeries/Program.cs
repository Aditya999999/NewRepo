using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_FibbonacciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a generator that will generate 20 Fibonacci numbers
            var generator = new Fibbonacci(20);

            foreach (var num in generator)
            {
                Console.Write($"{num} # ");
                
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
