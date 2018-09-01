using System;
using System.Threading;

namespace DemoApp13
{
    public  class MainClass
    {
        public static ThreadLocal<int> _field =
            new ThreadLocal<int>(() =>
        {
            return Thread.CurrentThread.ManagedThreadId;
        });

        public static void Main(string[] args)
        {
            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++ )
                {
                    Console.WriteLine("Therad A: {0}", x);
                }

            }).Start();

            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("Therad B: {0}", x);
                }
            }).Start();

            ThreadPool.QueueUserWorkItem((s) => 
            { 
                Console.WriteLine("Working on a thread from threadpool");
            });

            Console.ReadKey();
        }
    }
}
