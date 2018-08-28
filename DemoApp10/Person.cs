using System;

namespace DemoApp10
{
    public class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";
        }

        public Person(string Fornavn, string Efternavn, int Fødselsår)
        {
            this.Fornavn = Fornavn;
            this.Efternavn = Efternavn;
            this.Fødselsår = Fødselsår;
        }
        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }

        public int Alder()
        {
            return DateTime.Now.Year - Fødselsår;
        }

        public string ToString()
        {
            return FuldtNavn() + " alder: " + Alder(); 
        }



    }
}
