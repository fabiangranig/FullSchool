using System;

namespace _20221011_Member_verbergen
{
    class Zahl1
    {
        protected int Wert;
    }

    class Zahl2 : Zahl1
    {
        new protected string Wert;

        public Zahl2(int i, string s)
        {
            base.Wert = i;
            Wert = s;
        }

        public void Ausgabe()
        {
            Console.WriteLine(Wert);
            Console.WriteLine(base.Wert);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Zahl2 eineZahl = new Zahl2(10, "Zehn");
            eineZahl.Ausgabe();
        }
    }
}
