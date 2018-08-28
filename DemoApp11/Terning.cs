using System;

namespace DemoApp11
{
    public class Terning
    {
        public int værdi;
        private bool snyd;
        private static Random rnd = new Random();

        public Terning()
        {
            this.værdi = 1;
            this.snyd = false;
        }

        public Terning(bool snyd)
        {
            this.snyd = snyd;
            værdi = 1;
        }
        public void Skriv()
        {
            Console.WriteLine("[" + værdi + "]");
        }

        public void Ryst()
        {
            if (!snyd)
            {
                værdi = rnd.Next(1, 7);
            }
            else
            {
                værdi = 6;
            }
        }



    }
}
