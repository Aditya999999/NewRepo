namespace cs_con_SynchronousAsynchronousThread
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("=========== Methods are called Synchronously");
            Demo01();
            Console.WriteLine();

            Console.WriteLine("=========== Methods are called Aynchronously");
            Demo02();
            Console.WriteLine();
        }
        private static void Demo01()
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            Work work = new Work();
            Console.WriteLine("calling DoWork from Thread: {0}", Thread.CurrentThread.ManagedThreadId);
            
            Work.DoWork();
            //ThreadStart threadStart = new ThreadStart(Work.DoWork);
            //new Thread(threadStart).Start();

            Console.WriteLine("calling DoMoreWork from Thread: {0}", Thread.CurrentThread.ManagedThreadId);
            work.data = 40;
            //ThreadStart threadStart1 = new ThreadStart(work.DoMoreWork);
            //new Thread(threadStart1).Start();
            work.DoMoreWork();

            stopwatch.Stop();
            Console.WriteLine("Total Time taken: {0} milliseconds", stopwatch.ElapsedMilliseconds);
        }
        private static void Demo02()
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            // ThreadStart = void ()
            // ParameterizedThreadStart = void (object)
            Work work1 = new Work();
            Thread threadStart = new Thread(Work.DoWork);
            threadStart.Start();
            Console.WriteLine("calling DoWork from Thread: {0} Asynchronously",
                Thread.CurrentThread.ManagedThreadId);


            work1.data = 40;
            Thread t2 = new Thread(new ThreadStart(work1.DoMoreWork));
            t2.Start();
            Console.WriteLine("calling DoMoreWork from Thread: {0} Asynchronously",
                Thread.CurrentThread.ManagedThreadId);



            // NOTE: Wait for each of the threads to complete their tasks and join back to Parent Thread
            threadStart.Join();
            t2.Join();

            stopwatch.Stop();
            Console.WriteLine("Total Time taken: {0} milliseconds", stopwatch.ElapsedMilliseconds);
        }
    }


    class Work
    { 

            public static void DoWork()
            {
                Console.WriteLine("Static thread procedure");
            }
            public int data;
            public void DoMoreWork()
            {
                Console.WriteLine("Instance thread procedure. Data = {0}", data);
            }
    }
    
}