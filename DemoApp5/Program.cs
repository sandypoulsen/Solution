using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = LægSammen(5, 2);
            Console.WriteLine(res); // 7
            double res2 = BeregnAreal(5);
            Console.WriteLine(res2); // 78.53…
            Udskriv("Dette er en test"); // Dette er en test


            byte b = 255;
            checked
            {
                b++;
                b++;
            }
          
            Console.WriteLine(b);

            Console.ReadKey();
        }

        static int LægSammen(int a, int b)
        {
            return a + b;
        }

        static double BeregnAreal(double r)
        {
            return r * r * Math.PI;
        }

        static void Udskriv(string s)
        {
            Console.WriteLine(s);
        }
    }
}
