using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = @"c:\temp\tal.txt";

            if (!System.IO.File.Exists(s))
            {
                throw new ApplicationException("Filen c:\temp\tal.txt findes ikke!");

            }

            int tal = Read(s);
            Write(s, tal);
            

            Console.ReadKey();
        }

        static int Read(string s)
        {
            int tal;
            try
            {
                string indhold = System.IO.File.ReadAllText(s);
                tal = Convert.ToInt32(indhold);
              
            }
            catch (IOException)
            {
                throw;
            }
            catch(FormatException)
            {
                throw new ApplicationException("Indhold kan ikke konverteres til heltal");
            }

            return tal;
        }

        static void Write(string s, int tal)
        {
            tal++;
            try
            {
                File.WriteAllText(s, Convert.ToString(tal));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
