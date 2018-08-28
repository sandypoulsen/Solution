using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = @"c:\temp\test.txt";

            if(System.IO.File.Exists(s))
            {
                Console.WriteLine("file exists");

                Console.WriteLine(System.IO.File.ReadAllText(s));
            }

            Console.ReadKey();
        }
    }
}
