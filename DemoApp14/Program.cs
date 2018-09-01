using System;
using System.Threading.Tasks;

namespace DemoApp14
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            }).ContinueWith((i) => i.Result * 2, TaskContinuationOptions.OnlyOnRanToCompletion);
            Console.WriteLine(t.Result);
        }
    }
}
