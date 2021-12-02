//3AHWII Granig
//27.09.2021
//Ziffernsumme
using System;

namespace Ziffernsumme
{
    class Program
    {
        static int Ziffernsumme(int zahl)
        {
            //Die Zahl in einen  String konvertieren um auf Einzelne Zahlen zugreifen zu können
            string zahl_string = Convert.ToString(zahl);

            //Mithilfe einer for-Schleife durchgehen und die zahlen addieren
            int ergebnis = 0;
            for (int zaehler = 0; zaehler < zahl_string.Length; zaehler++)
            {
                ergebnis += Int32.Parse(Convert.ToString(zahl_string[zaehler]));
            }

            //Das Ergebnis zurückgeben
            return ergebnis;
        }

        static int Ziffernsumme2(int zahl)
        {
            //Deklarieren der Variablen
            int ergebnis = 0;

            //Mithilfe des %-Operators durchdividieren um auf die Zahl zu kommen
            while (zahl > 0)
            {
                ergebnis += zahl % 10;
                zahl = zahl / 10;
            }

            //Ausgabe des Ergebnisses
            return ergebnis;
        }

        static void Main(string[] args)
        {
            //Eingabe der Ziffernsumme
            Console.Write("Bitte geben Sie die Zahl ein mit welcher Sie die Ziffernsumme berechnen wollen: ");
            int eingabe1 = Convert.ToInt32(Console.ReadLine());

            //Ausgabe der Ziffernsumme mit Kontrolle ob der String nicht größer als 8 ist
            if (Convert.ToString(eingabe1).Length < 9)
            {
                Console.WriteLine("Die Ziffernsumme lautet: " + Ziffernsumme2(eingabe1) + "\n");
            }
            else
            {
                Console.WriteLine("Die Zahl ist länger als 8. \n");
            }
        }
    }
}
