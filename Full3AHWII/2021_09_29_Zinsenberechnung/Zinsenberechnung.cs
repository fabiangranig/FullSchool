//3AHWII Granig
//29.09.2021
//Zinsenbeispiel
using System;

namespace Zinsenberechnung
{
    class Program
    {
        static double BerechneKapital(double anfangskapital, int laufzeit, double zinssatz)
        {
            //Variablen deklarieren und den Zinssatz berechnen
            double endkapital = anfangskapital;
            double zinssatz_umgerechnet = zinssatz / 100 + 1;

            //Mithilfe for-Schleife die Jahre durchgehen
            for (int zaehler = 0; zaehler < laufzeit; zaehler++)
            {
                endkapital *= zinssatz_umgerechnet;
            }

            //Den Wert zurückgeben
            return endkapital;
        }

        static void Main(string[] args)
        {
            //Aufgabe 1
            //Eingabe der Werte
            Console.Write("Geben Sie das Anfangskapital ein: ");
            double anfangskapital = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geben Sie die Laufzeit ein: ");
            int laufzeit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geben Sie den Zinssatz ein: ");
            double zinssatz = Convert.ToDouble(Console.ReadLine());

            //Ausgabe des Zinssatzes
            Console.WriteLine("\nDas Ergebnis beträgt: " + Math.Round(BerechneKapital(anfangskapital, laufzeit, zinssatz), 4) + "\n");


            //Aufgabe 2
            //Variablen deklarieren
            double fixeskapital = 100;
            int fixelaufzeit = 10;
            double prozentsatz = 1.5;

            //Mithilfe der while-Schleife auf die 7.5% immer hochschalten und das Endkapital ausgeben
            while(7.75 > prozentsatz)
            {
                Console.WriteLine("Bei einem Prozentsatz von {0} ist das Endkapital: {1}", prozentsatz, Math.Round(BerechneKapital(fixeskapital,fixelaufzeit,prozentsatz)));
                prozentsatz += 0.25;
            }
        }
    }
}
