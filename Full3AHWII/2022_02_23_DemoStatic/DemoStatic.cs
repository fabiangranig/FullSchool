//Fabian Granig 3AHWII
//23.02.2022
//Beispiel: DemoStatic
using System;

namespace _20220223_DemoStatic
{
    class Person
    {
        private string _Vorname;
        private string _Nachname;
        private string _SVNR;
        private static int PersonCount;

        public static int PersonAnz
        {
            get { return PersonCount; }
        }
        public static double Firmengehalt()
        {
            return PersonCount * 1523.13;
        }

        public Person()
        {
            this._Nachname = "Muster";
            this._Vorname = "Max";
            this._SVNR = "1212231250";
            PersonCount++;
        }
        static Person()
        {
            PersonCount = 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anzahl der Personen {0}", Person.PersonAnz);
            Person MyPerson = new Person();
            Person MyPerson2 = new Person();
            Console.WriteLine("Anzahl der Personen {0}", Person.PersonAnz);
            Console.WriteLine("Das Firmengehalt lautet: {0}", Person.Firmengehalt());
        }
    }
}
