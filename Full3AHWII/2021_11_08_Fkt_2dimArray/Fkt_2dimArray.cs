//Fabian Granig 3AHWII
//08.11.2021
//zweidimensionales Array Beispiel
using System;

namespace Fkt_2dimArray
{
    class Program
    {
        static int[,] Einlesen()
        {
            //Das Array mit den 4 Wochen erstellen
            int[,] pegelstande = new int[4, 7];

            //Mithilfe der for-Schleife die Werte einlesen
            for(int zaehler = 0; zaehler < pegelstande.GetUpperBound(0)+1; zaehler++)
            {
                for(int zaehler2 = 0; zaehler2 < pegelstande.GetUpperBound(1)+1; zaehler2++)
                {
                    //Eingabe
                    Console.Write("Bitte geben Sie den Wert der {0}.Woche des {1}.Tages ein: ", zaehler+1, zaehler2+1);
                    pegelstande[zaehler, zaehler2] = Convert.ToInt32(Console.ReadLine());
                }

                //Leere Zeile
                Console.WriteLine(" ");
            }

            //Das Array zurückgeben
            return pegelstande;
        }

        static double Wochendurchschnitt(int[,] pegelstande, int woche)
        {
            //Alles zusammenzählen mithilfe der for-Schleife
            int summe = 0;
            for(int zaehler = 0; zaehler < pegelstande.GetUpperBound(1)+1; zaehler++)
            {
                summe += pegelstande[woche, zaehler];
            }

            //Den Durchschnitt berechnen
            double durchschnitt = 0.0 + summe / 7;

            //Den Wert zurückgeben
            return durchschnitt;
        }

        static int WochenMaxima(int[,] pegelstände, int woche)
        {
            //Mithilfe der for-Schleife den kleinsten Wert finden
            int groeßterwert = -1;
            for(int zaehler = 0; zaehler < pegelstände.GetUpperBound(1)+1; zaehler++)
            {
                if(groeßterwert < pegelstände[woche, zaehler])
                {
                    groeßterwert = pegelstände[woche, zaehler];
                }
            }

            //Den Wert zurückgeben
            return groeßterwert;
        }

        static int WochenMinima(int[,] pegelstände, int woche)
        {
            //Mithilfe der for-Schleife den kleinsten Wert finden
            int kleinsterwert = pegelstände[woche,0];
            for (int zaehler = 0; zaehler < pegelstände.GetUpperBound(1)+1; zaehler++)
            {
                if (kleinsterwert > pegelstände[woche, zaehler])
                {
                    kleinsterwert = pegelstände[woche, zaehler];
                }
            }

            //Den Wert zurückgeben
            return kleinsterwert;
        }

        static int arraydim2_Durchschnitt(int[,] pegelstände)
        {
            //Mithilfe der for-Schleife alles zusammenzählen und dann den Durchschnitt berechnen
            int summe = 0;
            for(int zaehler = 0; zaehler < pegelstände.GetUpperBound(0)+1; zaehler++)
            {
                for (int zaehler2 = 0; zaehler2 < pegelstände.GetUpperBound(1)+1; zaehler2++)
                {
                    summe += pegelstände[zaehler, zaehler2];
                }
            }

            int ergebnis = summe / 28;

            //Den Wert zurückgeben
            return ergebnis;
        }

        static int arraydim2_Maxima(int[,] pegelstände)
        {
            //Mithilfe der for-Schleife das Maximum rausfiltern
            int maxima = -1;
            for (int zaehler = 0; zaehler < pegelstände.GetUpperBound(0) + 1; zaehler++)
            {
                for (int zaehler2 = 0; zaehler2 < pegelstände.GetUpperBound(1) + 1; zaehler2++)
                {
                    if(pegelstände[zaehler, zaehler2] > maxima)
                    {
                        maxima = pegelstände[zaehler, zaehler2];
                    }
                }
            }

            //Den Wert zurückgeben
            return maxima;
        }

        static int arraydim2_Minima(int[,] pegelstände)
        {
            //Mithilfe der for-Schleife das Minimum rausfiltern
            int minima = pegelstände[0, 0];
            for (int zaehler = 0; zaehler < pegelstände.GetUpperBound(0) + 1; zaehler++)
            {
                for (int zaehler2 = 0; zaehler2 < pegelstände.GetUpperBound(1) + 1; zaehler2++)
                {
                    if(pegelstände[zaehler, zaehler2] < minima)
                    {
                        minima = pegelstände[zaehler, zaehler2];
                    }
                }
            }

            //Den Wert zurückgeben
            return minima;
        }

        static double[] Wochen_Durchschnitt_Array(int[,] pegelstände)
        {
            //Array erstellen
            double[] wochen_durchschnitt = new double[4];

            //Mithilfe der for-Schleife den Durchschnitt berechnen
            int summe = 0;
            for (int zaehler = 0; zaehler < 4; zaehler++)
            {
                for (int zaehler2 = 0; zaehler2 < 7; zaehler2++)
                {
                    summe += pegelstände[zaehler, zaehler2];
                }

                wochen_durchschnitt[zaehler] = summe / 7;
                summe = 0;
            }

            //Den Wert zurückgeben
            return wochen_durchschnitt;
        }

        static int[] Wochen_Maxima_Array(int[,] pegelstände)
        {
            //Array erstellen
            int[] wochen_maxima = new int[4];

            //Mithilfe der for-Schleife den Durchschnitt berechnen
            int Maxima = -1;
            for (int zaehler = 0; zaehler < 4; zaehler++)
            {
                for (int zaehler2 = 0; zaehler2 < 7; zaehler2++)
                {
                    if(pegelstände[zaehler, zaehler2] > Maxima)
                    {
                        Maxima = pegelstände[zaehler, zaehler2];
                    }
                }

                wochen_maxima[zaehler] = Maxima;
                Maxima = -1;
            }

            //Den Wert zurückgeben
            return wochen_maxima;
        }

        static int[] Wochen_Minima_Array(int[,] pegelstände)
        {
            //Array erstellen
            int[] wochen_minima = new int[4];

            //Mithilfe der for-Schleife den Durchschnitt berechnen
            int minima = 99999999;
            for (int zaehler = 0; zaehler < 4; zaehler++)
            {
                for (int zaehler2 = 0; zaehler2 < 7; zaehler2++)
                {
                    if (pegelstände[zaehler, zaehler2] < minima)
                    {
                        minima = pegelstände[zaehler, zaehler2];
                    }
                }

                wochen_minima[zaehler] = minima;
                minima = 999999999;
            }

            //Den Wert zurückgeben
            return wochen_minima;
        }

        static void Main(string[] args)
        {
            //Das 2 dimensionale Array erstellen für die 4 Wochen
            int[,] pegelstande = Einlesen();

            //Leere Zeile
            Console.WriteLine(" ");

            //Die Wochendurchschnitte, Wochenminima und Wochenmaxima ausgeben mithilfe der for-Schleife
            for(int zaehler = 0; zaehler < 4; zaehler++)
            {
                Console.WriteLine("Der Durchschnitt der {0}.Woche ist: {1}", zaehler+1, Wochendurchschnitt(pegelstande, zaehler));
                Console.WriteLine("Das Maximum der {0}.Woche ist: {1}", zaehler + 1, WochenMaxima(pegelstande, zaehler));
                Console.WriteLine("Das Minimum der {0}.Woche ist: {1}", zaehler + 1, WochenMinima(pegelstande, zaehler));

                //Leere Zeile
                Console.WriteLine(" ");
            }

            //Monatsberechnung
            Console.WriteLine("Die Monatsberechnung:");

            //Den Gesamtdurchschnitt, Gesamtminima und Gesamtmaxima ausgeben
            Console.WriteLine("Der gesamte Durchschnitt beträgt: " + arraydim2_Durchschnitt(pegelstande));
            Console.WriteLine("Das gesamte Maximum beträgt: " + arraydim2_Maxima(pegelstande));
            Console.WriteLine("Das gesamte Minimum beträgt: " + arraydim2_Minima(pegelstande));

            //Leere Zeile
            Console.WriteLine(" ");

            //Zusatzaufgabe
            Console.WriteLine("Zusatzaufgabe:");

            //Durchschnitt als Array Rückgabe
            double[] array_wochen_durchschnitt = Wochen_Durchschnitt_Array(pegelstande);
            int[] array_wochen_maxima = Wochen_Maxima_Array(pegelstande);
            int[] array_wochen_minima = Wochen_Minima_Array(pegelstande);

            //Mithilfe der for-Schleife ausgeben
            for(int zaehler2 = 0; zaehler2 < array_wochen_durchschnitt.Length; zaehler2++)
            {
                //Ausgabe
                Console.WriteLine("Der Durchschnitt der {0}.Woche ist: {1}", zaehler2 + 1, array_wochen_durchschnitt[zaehler2]);
                Console.WriteLine("Das Maxima der {0}.Woche ist: {1}", zaehler2 + 1, array_wochen_maxima[zaehler2]);
                Console.WriteLine("Das Minima der {0}.Woche ist: {1}", zaehler2 + 1, array_wochen_minima[zaehler2]);
            }
        }
    }
}
