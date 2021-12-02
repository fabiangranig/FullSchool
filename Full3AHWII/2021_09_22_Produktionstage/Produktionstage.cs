//3AHWII Granig
//22.09.2021
//Produktionstage
using System;

namespace Produktionstage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Einlesen wie viele Tage es gibt
            Console.Write("Bitte geben Sie ein wieviele Tage es gibt: ");
            int tage = Convert.ToInt32(Console.ReadLine());

            //Die Hammern einlesen
            int[] array = new Int32[tage];
            for (int zaehler = 0; zaehler < tage; zaehler++)
            {
                //Ausgabe was zum Eingeben ist
                Console.Write("Geben Sie die Hammer die am {0}.Tag produziert worden sind ein: ", zaehler + 1);
                array[zaehler] = Convert.ToInt32(Console.ReadLine());
            }

            //Aufgabe 1
            //Den Durchschnitt berechnen
            //Summe berechnen
            int summe = 0;
            for (int zaehler2 = 0; zaehler2 < tage; zaehler2++)
            {
                summe += array[zaehler2];
            }

            //Durchschnitt anzeigen
            Console.WriteLine("\nDer Durchschnitt beträgt: {0}", summe / tage);

            //Aufgabe 2
            //An welchen Tag am meisten produziert wurde
            int hoechstezahl = 0;
            string mehrerezahlen = "";

            //Mithilfe der for-Schleife checken welcher Wert der Größte ist
            for (int zaehler3 = 0; zaehler3 < array.Length; zaehler3++)
            {
                //Wenn ein neuer größter Wert gefunden wurde
                if (hoechstezahl < array[zaehler3])
                {
                    hoechstezahl = array[zaehler3];
                    mehrerezahlen = "";
                }

                //Wenn ein gleich großer Wert gefunden wurde
                if (hoechstezahl == array[zaehler3])
                {
                    int save = zaehler3 + 1;
                    mehrerezahlen += "\n" + save + ".Tag" + " ";
                }
            }

            //Ausgabe Aufgabe 2
            Console.WriteLine("\n" + "An diesen Tag/Tagen wurde am meisten produziert: " + mehrerezahlen);

            //Aufgabe 3
            string ausgabe_aufgabe3 = "";
            for (int zaehler4 = 0; zaehler4 < array.Length; zaehler4++)
            {
                //Kontrollieren ob der Array Wert größer ist als der Durchschnitt
                if (summe / tage < array[zaehler4])
                {
                    int save2 = zaehler4 + 1;
                    ausgabe_aufgabe3 += "\n" + save2 + ".Tag";
                }
            }

            //Ausgabe Aufgabe 3
            Console.WriteLine("\nIn diesem Tage liegt die Produktion über den Durchschnitt: " + ausgabe_aufgabe3);

            //Aufgabe 4
            int anzahl = 0;
            int hoechste_anzahl = -1;
            int welchezahl = 0;
            string ergebnis = "kein Wert";

            for (int zaehler5 = 0; zaehler5 < array.Length; zaehler5++)
            {
                //Mithilfe for-Schleife checken wie oft ein Wert im Array vorkommt
                for (int zaehler6 = 0; zaehler6 < array.Length; zaehler6++)
                {
                    if (array[zaehler5] == array[zaehler6])
                    {
                        anzahl++;
                        welchezahl = array[zaehler5];
                    }
                }

                //Kontrollieren ob der Wert sich schon bei den Ergebnissen befindet
                string converter = Convert.ToString(welchezahl);
                if (ergebnis.Contains(converter) == false)
                {
                    //Wenn zwei oder mehrere Zahlen die gleiche Anzahl haben
                    if (anzahl == hoechste_anzahl)
                    {
                        ergebnis += " / " + welchezahl;
                    }

                    //Wenn eine neue höchste Zahl gefunden wurde
                    if (anzahl > hoechste_anzahl)
                    {
                        hoechste_anzahl = anzahl;
                        ergebnis = "";
                        ergebnis = welchezahl + "";
                    }
                }

                //Anzahl wird zurückgesetzt
                anzahl = 0;
            }

            //Ausgabe Aufgabe 4
            Console.WriteLine("\nDiese/r Wert/Werte kommen am häufigsten vor: " + ergebnis);

            //Damit die Console offen bleibt
            Console.ReadLine();
        }
    }
}
