using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace cs_con_AsyncAwait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();

            Task.WaitAll(f1(), f2());

            sw.Stop();

            var elapsed = sw.ElapsedMilliseconds;
            Console.WriteLine($"elapsed: {elapsed} ms");

            async Task f1()
            {
                await Task.Delay(4000);
                Console.WriteLine("f1 finished");
            }

            async Task f2()
            {
                await Task.Delay(7000);
                Console.WriteLine("f2 finished");
            }

        }
    }
}
