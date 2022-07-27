//Printing elements of array
namespace cs_con_SeventhProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, ADITYA!");
            int[] arr = new int[11] { 12, 13, 14, 15, 21, 23, 34, 543, 4334, 34234, 43243 };
            for (int i = 0; i < arr.Length; i++) { 
                Console.WriteLine("Elements of array at position "+ i+ " is {0}.",arr[i]);
                Console.WriteLine();
            }









            //2D array

            int[,] arr2d = new int[2, 4] { { 1, 2, 4, 5 }, { 3, 5, 6, 3 } };
            int rows = arr2d.GetLength(0);
            int cols = arr2d.GetLength(1);
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {

                    Console.Write("{0} ", arr2d[i, j]); 
                }
                Console.WriteLine();
            }
     
        }
    }
}