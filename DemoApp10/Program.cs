using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Hans", "Hansen", 1987);
            Console.WriteLine(p1.ToString());

            Person p2 = new Person();
            Console.WriteLine(p2.ToString());

            Console.ReadKey();
        }
    }
}
