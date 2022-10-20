using System;

namespace _20221017_Einfuehrung
{
    class Program
    {
        class Zahl1
        {
            protected int Wert;

            public virtual void Ausgabe()
            {
                Console.WriteLine(Wert);
            }

        }

        class Zahl2 : Zahl1
        {
            new protected string Wert;

            public Zahl2(int i, string s)
            {
                base.Wert = i;
                Wert = s;
            }

            public override void Ausgabe()
            {
                Console.WriteLine(Wert);
                Console.WriteLine(base.Wert);
            }
        }

        static void Main(string[] args)
        {
            Zahl2 eineZahl = new Zahl2(10, "Zehn");
            eineZahl.Ausgabe();

            Zahl1 nocheineZahl = new Zahl1();
            nocheineZahl.Ausgabe();

            Console.WriteLine();

            //finde heraus, welche Methode aufgerufen wird
            nocheineZahl = eineZahl;
            nocheineZahl.Ausgabe();

            Console.Read();
        }
    }
}
