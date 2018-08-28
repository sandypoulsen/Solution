using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.LøkkeMetode(1, 10);

            Console.ReadLine();
        }

        void LøkkeMetode(int a, int b)
        {
            if(a <= b)
            {
                Console.WriteLine(a);
                LøkkeMetode(++a, b);
            }
            
        }
    }
}
