using System;

namespace _20220920_Klassen_ableiten
{
    class Zahl1
    {
        protected int Wert;
        public void Ausgabe()
        {
            Console.WriteLine(this.Wert);
        }
    }

    class Zahl2 : Zahl1
    {
        public void Eingabe(int i)
        {
            this.Wert = i;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Zahl2 eineZahl = new Zahl2();
            eineZahl.Eingabe(11);
            eineZahl.Ausgabe();
        }
    }
}
