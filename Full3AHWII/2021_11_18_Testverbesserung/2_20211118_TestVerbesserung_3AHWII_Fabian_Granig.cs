//Fabian Granig 3AHWII
//20.10.2021
//Test Aufgabe b)
using System;

namespace Test_3AHWII_FabianGranig_Aufgabe_2
{
    class Program
    {
        static int Tage_einlesen()
        {
            //Einlesen wieviele Tage aufgezeichnet werden sollen
            Console.Write("Wie viele Tagen sollen aufgezeichnet werden? ");
            int tage = Convert.ToInt32(Console.ReadLine());

            //Den Wert zurückgeben
            return tage;
        }
        
        //Einlesen der kaputten Bauteile
        static int[] Bauteile_einlesen(int tage)
        {
            //Ein Array erstellen
            int[] kaputte_Bauteile = new Int32[tage];

            //Mithilfe der for-Schleife ausgeben
            for(int zaehler = 0; zaehler < tage; zaehler++)
            {
                //Eingabe
                Console.Write("Bitte geben Sie die kaputten Teilen vom {0}.Tag ein: ", zaehler + 1);
                kaputte_Bauteile[zaehler] = Convert.ToInt32(Console.ReadLine());
            }

            //Das Array zurückgeben
            return kaputte_Bauteile;
        }

        //Alle Werte ausgeben
        static void Array_ausgeben(int[] array)
        {
            //Mithilfe der for-Schleife
            for(int zaehler = 0; zaehler < array.Length; zaehler++)
            {
                Console.WriteLine("Der Wert am {0}.Tag lautet: {1}", zaehler+1, array[zaehler]);
            }
        }

        //durchschnittliche Anzahl berechnen
        static double Durchschnitt(int[] array)
        {
            //Die Summe mitfilfe der for-Schleife berechnen
            double summe = 0.0;
            for(int zaehler = 0; zaehler < array.Length; zaehler++)
            {
                summe += array[zaehler];
            }

            //Durch die Anzahl dividieren
            double ergebnis = summe / array.Length;

            //Den Wert zurückgeben
            return ergebnis;
        }

        //Werte welche unter dem Durschnitt liegen zurückgeben
        static int[] Werte_unter_Durchschnitt(int[] array, double durchschnitt)
        {
            //Mithilfe der for-Schleife alle Werte unter dem Durchschnitt herausfinden
            int zaehler2 = 0;
            for(int zaehler = 0; zaehler < array.Length; zaehler++)
            {
                //Bedingung das es den Tag speichert
                if(array[zaehler] < durchschnitt)
                {
                    zaehler2++;
                }
            }

            //Array erstellen
            int[] array1 = new int[zaehler2];

            int zaehler3 = 0;
            for (int zaehler = 0; zaehler < array.Length; zaehler++)
            {
                //Bedingung das es den Tag speichert
                if (array[zaehler] < durchschnitt)
                {
                    array1[zaehler3] = zaehler;
                    zaehler3++;
                }
            }

            //Das Array zurückgeben
            return array1;
        }

        //Funktion welche berechnet welche Zahl am Häfigsten vorkommt
        static int welche_Anzahl_am_Haufigsten_vorkommt(int[] array)
        {
            //Mithilfe der for-Schleife herausfinden welche Anzahl am Häufigsten vorkommt
            int zahl = 0;
            int zahl_anzahl = 0;

            int welchezahl_anzahl = 0;
            for(int zaehler = 0; zaehler < array.Length; zaehler++)
            {
                for(int zaehler2 = 0; zaehler2 < array.Length; zaehler2++)
                {
                    //Bedingung
                    if(array[zaehler] == array[zaehler2])
                    {
                        welchezahl_anzahl++;
                    }
                }

                //Bedingung2
                if(welchezahl_anzahl > zahl_anzahl)
                {
                    zahl = array[zaehler];
                    zahl_anzahl = welchezahl_anzahl;
                }

                //Werde zurückgeben
                welchezahl_anzahl = 0;
            }

            //Den Wert zurückgeben
            return zahl;
        }

        //Funktion die berechnet wie oft die häufigste Zahl vorkommt
        static int Haufigste_Anzahl_vor(int[] array)
        {
            //Von der vorigen Funktion den Wert holen
            int wert = welche_Anzahl_am_Haufigsten_vorkommt(array);

            //Schauen wie oft dieser vorkommt
            int zaehler2 = 0;
            for(int zaehler = 0; zaehler < array.Length; zaehler++)
            {
                //Bedingung
                if(array[zaehler] == wert)
                {
                    zaehler2++;
                }
            }

            //Den Wert zurückgeben
            return zaehler2;
        }

        static void Main(string[] args)
        {
            //Einlesen wie viele Tage aufgezeichnet werden sollen
            int tage = Tage_einlesen();

            //Leere Zeile
            Console.WriteLine(" ");

            //Einlesen der kaputten Teile pro Tag in ein Array
            int[] kaputte_Bauteile = Bauteile_einlesen(tage);

            //Leere Zeile
            Console.WriteLine(" ");

            //Die Werte ausgeben
            Array_ausgeben(kaputte_Bauteile);

            //Leere Zeile
            Console.WriteLine(" ");

            //Durschnittliche Anzahl ausgeben
            double durchschnitt = Durchschnitt(kaputte_Bauteile);
            Console.WriteLine("Der Durchschnitt beträgt: {0}", durchschnitt);

            //Leere Zeile
            Console.WriteLine(" ");

            //Alle Wert die unter dem Durschnitt liegen ausgeben
            int[] array_werte_unter_dem_Durchschnitt = Werte_unter_Durchschnitt(kaputte_Bauteile, durchschnitt);
            Console.WriteLine("An folgenden Tagen sind die kaputten Teile unter dem Durschnitt: ");
            for(int zaehler = 0; zaehler < array_werte_unter_dem_Durchschnitt.Length; zaehler++)
            {
                Console.WriteLine((array_werte_unter_dem_Durchschnitt[zaehler]+1) + ".Tag");
            }

            //Leere Zeile
            Console.WriteLine(" ");

            //Der Wert welcher am Häufigsten vorkommt ausgeben
            Console.WriteLine("Diese Anzahl kommt am Häufigsten vor: " + welche_Anzahl_am_Haufigsten_vorkommt(kaputte_Bauteile));
            Console.WriteLine("Die häufigste Zahl kommt " + Haufigste_Anzahl_vor(kaputte_Bauteile) + ".Mal vor.");
        }
    }
}
