namespace cs_con_EigthProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int i = 10;
            string s = "Hello Aditya";

            m(i);

            m(s);
        }
        static void m(int x)
        {
            Console.WriteLine("Received{0}, type:{1}", x, x.GetType());
        }
        static void m(string s)
        {
            Console.WriteLine(s, s.GetType());
        }
    }
}