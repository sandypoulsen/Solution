using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Beregninger.LægSammen(2, 3));
            Console.WriteLine(Beregninger.TrækFra(100, 20));


            Test(out string s);
            Console.WriteLine(s);

            if(System.Diagnostics.Debugger.IsAttached)
            {
                Console.ReadKey();
            }
        }

        static void Test(out string s)
        {
            s = "hello";
        }
    }
}
