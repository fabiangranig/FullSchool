//Fabian Granig 3AHWII
//24.11.2021
//Lotto Beispiel
using System;

namespace _20211124_Lottobeispiel_Fabian_Granig_3AHWIII
{
    class Program
    {
        static int[,] die_Ticket_Zahlen_einlesen(int[,] array)
        {
            //Mithilfe der for-Schleifen die Tickets einlesen
            for (int zaehler = 0; zaehler < array.GetLength(0); zaehler++)
            {
                for (int zaehler2 = 0; zaehler2 < 7; zaehler2++)
                {
                    //Eingabe
                    Console.Write("Geben Sie beim {0}.Ticket die {1}.Zahl ein: ", zaehler + 1, zaehler2 + 1);
                    array[zaehler, zaehler2] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Den Wert zurückgeben
            return array;
        }

        static int[] gezogene_Zahlen()
        {
            int[] gezogeneTipps = new int[7];
            for (int zaehler = 0; zaehler < gezogeneTipps.Length; zaehler++)
            {
                //Eingabe
                Console.Write("Geben Sie den {0}.gezogene Zahl ein: ", zaehler + 1);
                gezogeneTipps[zaehler] = Convert.ToInt32(Console.ReadLine());
            }

            //Den Wert zurückgeben
            return gezogeneTipps;
        }

        static int[] richtige_Zahlen_Anzahl(int[,] ticket_array, int[] gezogeneTipps)
        {
            //Mithilfe der for-Schleife kontrollieren
            int[] anzahl_richtig = new int[ticket_array.GetLength(0)];
            for (int zaehler1 = 0; zaehler1 < ticket_array.GetLength(0); zaehler1++)
            {
                anzahl_richtig[zaehler1] = 0;
                for (int zaehler2 = 0; zaehler2 < 6; zaehler2++)
                {
                    if (ticket_array[zaehler1, zaehler2] == gezogeneTipps[zaehler2])
                    {
                        anzahl_richtig[zaehler1]++;
                    }
                }
            }

            //Den Wert zurückgeben
            return anzahl_richtig;
        }

        static bool[] richtige_zusätzliche_Zahlen_Anzahl(int[,] ticket_array, int[] gezogeneTipps)
        {
            //Mithilfe der for-Schleife kontrollieren
            bool[] zusatzzahlen = new bool[ticket_array.GetLength(0)];
            for (int zaehler = 0; zaehler < ticket_array.GetLength(0); zaehler++)
            {
                if (ticket_array[zaehler, 6] == gezogeneTipps[6])
                {
                    zusatzzahlen[zaehler] = true;
                }
                else
                {
                    zusatzzahlen[zaehler] = false;
                }
            }

            //Den Wert zurückgeben
            return zusatzzahlen;
        }

        static void Ausgabe_Anzahl_und_Zusatzzahl(int[] anzahl_richtig, bool[] zusatzzahlen)
        {
            Console.WriteLine("Ausgabe der Ergebnisse:");

            //Ausgeben mithilfe einer for-Schleife
            for(int zaehler = 0; zaehler < anzahl_richtig.Length; zaehler++)
            {
                Console.WriteLine("Das {0}.Ticket hat {1} richtige Zahlen und die Zusatzzahl ist {2}", zaehler+1,anzahl_richtig[zaehler],zusatzzahlen[zaehler]);
            }
        }

        static double Durchschnitt_Array(int[] array)
        {
            //Mithilfe der for-Schleife eine Summe bilden
            double summe = 0.0;
            for(int zaehler = 0; zaehler < array.Length; zaehler++)
            {
                summe += array[zaehler];
            }

            //Den Durchschnitt berechnen
            double durchschnitt = summe / array.Length;

            //Den Wert zurückgeben
            return durchschnitt;
        }

        static int Haufigste_getippte_Zahl(int[,] array)
        {
            //Variablen deklarieren
            int haufigstezahl = -1;
            int haufigstezahl_anzahl = 0;
            int zaehler_zahl = -1;
            int zaehler_anzahl = 0;

            //Mithilfe der for-Schleife auswerten
            for(int zaehler = 0; zaehler < array.GetLength(0); zaehler++)
            {
                for(int zaehler2 = 0; zaehler2 < array.GetLength(1); zaehler2++)
                {
                    zaehler_anzahl = 0;
                    zaehler_zahl = array[zaehler, zaehler2];
                    for(int zaehler3 = 0; zaehler3 < array.GetLength(0); zaehler3++)
                    {
                        for(int zaehler4 = 0; zaehler4 < array.GetLength(1); zaehler4++)
                        {
                            if(zaehler_zahl == array[zaehler3, zaehler4])
                            {
                                zaehler_anzahl++;
                            }
                        }
                    }

                    if(zaehler_anzahl > haufigstezahl_anzahl)
                    {
                        haufigstezahl = zaehler_zahl;
                        haufigstezahl_anzahl = zaehler_anzahl;
                    }
                }
            }

            //Den Wert zurückgeben
            return haufigstezahl;
        }

        static void Main(string[] args)
        {
            //Eingabe der Lotto Ticket Anzahl
            Console.Write("Geben Sie bitte die Anzahl der Lottotickets ein: ");
            int ticket_anzahl = Convert.ToInt32(Console.ReadLine());

            //Erstellen des Arrays für die Tickets
            int[,] ticket_array = new int[ticket_anzahl, 7];

            //Tickets einlesen
            ticket_array = die_Ticket_Zahlen_einlesen(ticket_array);

            //Leere Zeile
            Console.WriteLine(" ");

            //Den gezogenen Tipp einlesen
            int[] gezogeneTipps = gezogene_Zahlen();

            //Die richtige geratenen Zahlen
            int[] anzahl_richtig = richtige_Zahlen_Anzahl(ticket_array, gezogeneTipps);
            bool[] zusatzzahlen = richtige_zusätzliche_Zahlen_Anzahl(ticket_array, gezogeneTipps);

            //Leere Zeile
            Console.WriteLine(" ");

            //Aufgabe1: Ausgabe
            Ausgabe_Anzahl_und_Zusatzzahl(anzahl_richtig, zusatzzahlen);

            //Leere Zeile
            Console.WriteLine(" ");

            //Aufgabe2: Durchschnitt
            Console.WriteLine("Die durchschnittliche Anzahl beträgt: {0}",Durchschnitt_Array(anzahl_richtig));

            //Leere Zeile
            Console.WriteLine(" ");

            //Aufgabe3: Zahl ausgeben welche am Häufigsten getippt wurde
            Console.WriteLine("Die häufigste getippte Zahl ist: {0}", Haufigste_getippte_Zahl(ticket_array));

            //Das die Konsole offen bleibt
            Console.ReadLine();
        }
    }
}
