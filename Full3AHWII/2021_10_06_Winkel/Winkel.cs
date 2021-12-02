//3AHWII Granig
//27.09.2021
//Winkel L
using System;

namespace Winkel
{
    class Program
    {
        static int Fakultaet(int a)
        {
            int ergebnis = 1;
            for (int i = 1; i <= a; i++)
            {
                ergebnis = ergebnis * i;
            }
            return ergebnis;
        }

        static double Winkel(double zahl, int anzahl)
        {
            //Variablen deklarieren
            double ergebnis = 0;

            //In Radiant umrechnung
            double rad = Math.PI * zahl / 180;

            //Mithilfe der for-Schleife das Ergebnis berechnen
            for(int zaehler = 1; zaehler < anzahl+1; zaehler++)
            {
                ergebnis += Math.Pow((-1), zaehler - 1) * Math.Pow(rad, 2 * zaehler - 2) / Fakultaet(2 * zaehler - 2);
            }

            //Wert zurückgeben
            return ergebnis;
        }

        static void Main(string[] args)
        {
            //Eingeben
            Console.Write("Geben Sie bitte den Wert ein: ");
            double eingabe = Convert.ToDouble(Console.ReadLine());
            Console.Write("Wie oft möchten Sie durchgehen: ");
            int anzahl = Convert.ToInt32(Console.ReadLine());

            //Ausgabe
            Console.WriteLine("Das Ergebnis beträgt: {0}", Winkel(eingabe, anzahl));
        }
    }
}
