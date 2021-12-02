//3AHWII Granig
//11.10.2021
//Funktion Array
using System;

namespace Funktion_Array
{
    class Program
    {
        static double[] Einlesen_der_Zahlen(int anzahl)
        {
            //Mithilfe der for-Schleife Werte einlesen
            double[] ergebnis_array = new double[anzahl];
            for(int zaehler = 0; zaehler < anzahl; zaehler++)
            {
                //Eingabe
                Console.Write("Gib bitte die {0}.Zahl ein: ", zaehler+1);
                ergebnis_array[zaehler] = Convert.ToDouble(Console.ReadLine());
            }

            //Den Wert zurückgeben
            return ergebnis_array;
        }

        static double Durchschnitt(double[] array)
        {
            //Mithilfe der for-Schleife alles zusammenzählen
            double ergebnis = 0;
            for(int zaehler = 0; zaehler < array.Length; zaehler++)
            {
                ergebnis += array[zaehler];
            }

            //Den Durchnitt berechnen
            ergebnis = ergebnis / array.Length;

            //Rückgabe des Wertes
            return ergebnis;
        }

        static void Main(string[] args)
        {
            //Eingabe wie viele Tage gemessen werden
            Console.Write("Geben Sie bitte die Anzahl der Tage ein: ");
            int anzahl = Convert.ToInt32(Console.ReadLine());

            //In einer Funktion die Werte an verschiedenen Tagen einlesen
            double[] array = Einlesen_der_Zahlen(anzahl);

            //Durchschnitt berechnen
            double Durchschnitt_Pegelstände = Durchschnitt(array);

            //Leere Zeile
            Console.WriteLine(" ");

            //Mithilfe einer for-Schleife kontrollieren welcher Tag mit Pegelwert über den Durchnitt liegt
            Console.WriteLine("Tage welche über dem Durchnitt {0} liegen: ", Durchschnitt_Pegelstände);
            for(int zaehler = 0; zaehler < array.Length; zaehler++)
            {
                if(array[zaehler] > Durchschnitt_Pegelstände)
                {
                    Console.WriteLine("{0}.Tag: {1}", zaehler+1, array[zaehler]);
                }
            }

            //Leere Zeile
            Console.WriteLine(" ");

            //Mithilfe der for-Schleife kontrollieren welcher Tag mit Pegelwert unter dem Durchnitt liegt
            Console.WriteLine("Tage welche unter dem Durchnitt {0} liegen: ", Durchschnitt_Pegelstände);
            for (int zaehler = 0; zaehler < array.Length; zaehler++)
            {
                if (array[zaehler] < Durchschnitt_Pegelstände)
                {
                    Console.WriteLine("{0}.Tag: {1}", zaehler + 1, array[zaehler]);
                }
            }
        }
    }
}
