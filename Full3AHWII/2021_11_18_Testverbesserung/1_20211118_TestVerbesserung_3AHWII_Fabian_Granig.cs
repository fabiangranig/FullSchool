//Fabian Granig 3AHWII
//20.10.2021
//Test Aufgabe a)
using System;

namespace Test_3AHWII_GranigFabian
{
    class Program
    {
        static double BerechneAnhalteWeg(double geschwindigkeit)
        {
            //Formel berechnung
            double reaktionsweg = (3.0 / 10 ) * geschwindigkeit;
            double bremsweg = Math.Pow(1.0 / 10 * geschwindigkeit, 2);

            //Zusammenzählen für die gesamte verbrauchte Zeit
            double gesamtzeit = reaktionsweg + bremsweg;

            //Den Wert zurückgeben
            return gesamtzeit;
        }

        static void Main(string[] args)
        {
            //Ausgabe was das Programm tut
            Console.WriteLine("Das Programm gibt den Bremsweg 30 - 130 km/h in Metern aus.");

            //Mithilfe der for-Schleife
            for(int zaehler = 30; zaehler < 135; zaehler = zaehler + 5)
            {
                //Ausgabe
                Console.WriteLine("Der Anhalteweg bei einer Geschwindigkeit von {0} km/h ist {1} Meter.", zaehler, BerechneAnhalteWeg(zaehler));
            }
        }
    }
}
