using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.navn = "Hans";
            p1.alder = 32;
            p1.køn = Køn.Mand;

            Person p2 = p1;

            p1.navn = "Kurt";

            Console.WriteLine(p1.køn);
            Console.WriteLine((int)p1.køn);

            Console.WriteLine(Køn.Kvinde);
            Console.WriteLine((int)Køn.Kvinde);

            int x = 10;
            x++;
            x--;
            x += 20;
            Console.WriteLine(x);

            double y = 12.5;
            y++;
            y--;
            y *= 2;
            Console.WriteLine(y);

           
            for(int i = 1; i <= 10; i++)
            { 
                for(int j = 1; j <= 10; j++)
                {
                    if (j * i > 50)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"{i * j,4}");
                }
                Console.Write("\n");
                
            }


            DayOfWeek d =  DateTime.Now.DayOfWeek;

            switch (d)
            {
                case DayOfWeek.Sunday:
                    break;
                case DayOfWeek.Monday:
                    break;
                case DayOfWeek.Tuesday:
                    break;
                case DayOfWeek.Wednesday:
                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Saturday:
                    break;
            }


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    struct Person
    {
        public string navn;
        public int alder;
        public Køn køn;
    }

    enum Køn
    {
        Mand = 10,
        Kvinde = 20
    }
}
