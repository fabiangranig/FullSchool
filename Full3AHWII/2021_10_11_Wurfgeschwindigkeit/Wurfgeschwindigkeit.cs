//3AHWII Granig
//11.10.2021
//Wurfgeschwindigkeit
using System;

namespace Wurfgeschwindigkeit
{
    class Program
    {
        static double[] Wurfgeschwindigkeit()
        {
            //Mithilfe der while Schleife herausfinden wann der Ball aufprallt
            int counter = 0;
            double wert = 0;
            while(1 == 1)
            {
                //Formel
                wert = 20 * counter - (9.81 / 2) * Math.Pow(counter, 2);

                //Wenn der Wert niedrierger ist abbrechen
                if(wert <= 0 && counter != 0)
                {
                    break;
                }

                //Counter hochzählen
                counter++;
            }

            //Array zum Speichern der Werte erstellen
            double[] array = new double[counter];

            //Mithilfe der for-Schleife alle Werte zum Array hinzufügen
            for(int zaehler = 0; zaehler < array.Length; zaehler++)
            {
                array[zaehler] = 20 * zaehler - (9.81 / 2) * Math.Pow(zaehler, 2);
            }

            //Rückgabe
            return array;
        }

        static double[] hoechster_Wert(double[] array)
        {
            //Mithilfe der for-Schleife herausfinden welcher Wert der größte ist
            double[] ergebnis = new double[2];
            ergebnis[0] = array[0];
            ergebnis[1] = 1;
            for(int zaehler = 1; zaehler < array.Length; zaehler++)
            {
                if(ergebnis[0] < array[zaehler])
                {
                    ergebnis[0] = array[zaehler];
                    ergebnis[1] = zaehler;
                }
            }

            //Den Wert zurückgeben
            return ergebnis;
        }

        static void Main(string[] args)
        {
            //Speicherplatz für den Array
            double[] array = Wurfgeschwindigkeit();

            //höchster Wert Speicherplatz
            double[] array_ergebnis = hoechster_Wert(array);

            //Ausgabe höchster Wert
            Console.WriteLine("Der höchste Punkt ist {0} Meter und er war in der {1}.Sekunde.", array_ergebnis[0], array_ergebnis[1]);

            //Ausgabe nach unten gefallen
            Console.WriteLine("Er ist {0} Meter nach unten gefallen.", array_ergebnis[0
                ]);
        }
    }
}
