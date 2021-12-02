//Fabian Granig 3AHWII
//21.10.2021
//Testbeispiel 1
using System;

namespace Testbeispiel_1
{
    class Program
    {
        static double BerechneAnhalteWeg(int geschwindigkeit)
        {
            //Variablen deklarieren
            double ergebnis = 0.0;

            //Berechnung
            double reaktionsweg = (3.0 / 10) * geschwindigkeit;
            double bremsweg = Math.Pow((1.0 / 10) * geschwindigkeit, 2);
            ergebnis = reaktionsweg + bremsweg;

            //Den Wert zurückgeben
            return ergebnis;
        }

        static void Main(string[] args)
        {
            //gesamte Aufgabenstellungslink: 
            //https://drive.google.com/drive/folders/1LbNt1dBsB496WXvIrXF5BoyhusA6Dd5E?usp=sharing

            //Mithilfe der for-Schleife in 5er Schritten ausgeben
            for (int zaehler = 30; zaehler < 135; zaehler = zaehler + 5)
            {
                //Ausgabe
                Console.WriteLine("Bei der Geschwindigkeit {0} km/h beträgt der Anhalteweg {1} Meter.", zaehler, BerechneAnhalteWeg(zaehler));
            }
        }
    }
}
