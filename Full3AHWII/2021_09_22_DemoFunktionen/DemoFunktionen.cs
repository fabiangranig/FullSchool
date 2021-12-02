//3AHWII Granig
//22.09.2021
//Demo Funktion
using System;

namespace DemoFunktionen
{
    class Program
    {
        static int Hoch(int a, int b)
        {
            int ergebnis = 1;

            for (int i = 0; i <= b; i++)
            {
                ergebnis = ergebnis * a;
            }

            return ergebnis;
        }

        static int Fakultaet(int a)
        {
            int ergebnis = 1;
            for (int i = 1; i <= a; i++)
            {
                ergebnis = ergebnis * i;
            }
            return ergebnis;
        }

        static void Main(string[] args)
        {
            int x = 3;
            int y = 2;

            int Erg;

            Erg = Hoch(x, y);

            Console.WriteLine("Das Ergebnis lautet: " + Erg);

            Console.WriteLine("Die Fakultät beträgt: " + Fakultaet(3));
        }
    }
}
