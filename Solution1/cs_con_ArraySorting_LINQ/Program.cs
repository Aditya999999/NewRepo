using System;
using System.Linq;
namespace cs_con_ArraySorting_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 4, 6, 1, 3, 7, 8, 5, 32, 12, 23 };
            var sort = from s in arr
                       orderby s
                       select s;
            foreach(int c in sort)
                {
                    Console.WriteLine(c);
                }
         }
    }
}