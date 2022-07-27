using System;
namespace cs_con_EleventhProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            System.Collections.ArrayList arrayList = new System.Collections.ArrayList();

            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);
            arrayList.Add(5);
            arrayList.Add(6);

            arrayList.Add("Hello Aditya");
            arrayList.Add(true);


            Console.WriteLine(arrayList[4]);
            Console.WriteLine(arrayList[2]);    
            Console.WriteLine(arrayList[1]);

            arrayList.Add(new int[4] { 1, 2, 3, 4 });
            int[] arr = arrayList[index: 0] as int;     

        }
    }
}
