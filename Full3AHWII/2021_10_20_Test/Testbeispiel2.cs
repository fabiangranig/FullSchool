//Fabian Granig 3AHWII
//21.10.2021
//Testbeispiel 2
using System;

namespace Testbeispiel_2
{
    class Program
    {
        //Funktion zum Einlesen der Tage
        static int Tage_Einlesen()
        {
            //Einlesen
            Console.Write("Geben Sie bitte die Tage ein: ");
            int tag = Convert.ToInt32(Console.ReadLine());

            //Den Wert zurück
            return tag;
        }

        //Funktion um das kaputte Teile Array einzugeben
        static int[] kaputte_Teile_Einlesen(int tage)
        {
            //Array deklarieren
            int[] kaputteTeile = new Int32[tage];

            //Mithilfe der for-Schleife die Werte einlesen
            for(int zaehler = 0; zaehler < kaputteTeile.Length; zaehler++)
            {
                //Eingabe
                Console.Write("Geben Sie bitte das {0}.Teil ein: ", zaehler+1);
                kaputteTeile[zaehler] = Convert.ToInt32(Console.ReadLine());
            }

            //Das befüllte Array zurückgeben
            return kaputteTeile;
        }

        //Funktion um aus einem Array den Durchschnitt zu berechnen
        static double Durchschnitt_Array(int[] array)
        {
            //Mithilfe der for-Schleife alle Werte aus dem Array zusammenzählen
            double summe = 0.0;
            for(int zaehler = 0; zaehler < array.Length; zaehler++)
            {
                //Summieren
                summe += array[zaehler];
            }

            //Summe durch Anzahl um den Durchschnitt zu bekommen
            double ergebnis = summe / array.Length;

            //Den Wert zurückgeben
            return ergebnis;
        }

        //Funktion um aus einem Array herauszufinden welche Werte unter dem Durschnitt sind
        static string Werte_unter_dem_Durchschnitt(int[] array, double durchschnitt)
        {
            //Mithilfe der for-Schleife bestimmen welche Werte über dem Durchschnitt liegen
            string ergebnis = "";
            for(int zaehler = 0; zaehler < array.Length; zaehler++)
            {
                if(durchschnitt > array[zaehler])
                {
                    int tag = zaehler + 1;
                    ergebnis += "\nAm Tag " + tag + " liegt der Wert " + array[zaehler] + " unter dem Durchschnitt.";
                }
            }

            //Das Ergebnis zurückgeben
            return ergebnis;
        }

        //Funktion welche eine Zahl welche am Häufigsten vorkommt und wie oft diese vorkommt
        static string Haufige_Zahl(int[] array)
        {
            //Variablen deklarieren
            string ergebnis = "\n";
            string checker_ob_der_Wert_schonmal_war = " ";

            //Mithilfe der for-Schleife herausfinden welcher Wert am Häufigsten vorkommt
            int derzeitige_haufigste_zahl_anzahl = -1;
            int durchlauf_haufigste_zahl = 0;
            int durchlauf_haufigste_zahl_anzahl = 0;
            for (int zaehler = 0; zaehler < array.Length; zaehler++)
            {
                //Zuweisen welcher Wert gecheckt wird
                durchlauf_haufigste_zahl = array[zaehler];

                for(int zaehler2 = 0; zaehler2 < array.Length; zaehler2++)
                {
                    //Checken ob das der gleiche Wert ist
                    if(durchlauf_haufigste_zahl == array[zaehler2])
                    {
                        durchlauf_haufigste_zahl_anzahl++;
                    }
                }

                //Checken ob man den Wert schon Mal hatte
                if(!checker_ob_der_Wert_schonmal_war.Contains(" " + Convert.ToString(durchlauf_haufigste_zahl) + " "))
                {
                    //Hinzufügen der hereingelassenen Zahl
                    checker_ob_der_Wert_schonmal_war += Convert.ToString(durchlauf_haufigste_zahl) + " ";

                    //Hinzufügen zum Ergebnis String
                    if (durchlauf_haufigste_zahl_anzahl == derzeitige_haufigste_zahl_anzahl)
                    {
                        ergebnis += "\nEin Wert mit der gleichen Anzahl ist: " + durchlauf_haufigste_zahl;
                    }

                    if (durchlauf_haufigste_zahl_anzahl > derzeitige_haufigste_zahl_anzahl)
                    {
                        derzeitige_haufigste_zahl_anzahl = durchlauf_haufigste_zahl_anzahl;
                        
                        ergebnis = "\n";
                        ergebnis += "Der häufigste Wert ist " + durchlauf_haufigste_zahl + " mit einer Anzahl von " + durchlauf_haufigste_zahl_anzahl + ".";
                    }
                }

                durchlauf_haufigste_zahl = 0;
                durchlauf_haufigste_zahl_anzahl = 0;
            }

            //Ergebnis zurückgeben
            return ergebnis;
        }

        //Hauptprogramm
        static void Main(string[] args)
        {
            //Test Aufgabenlink: 
            //https://drive.google.com/drive/folders/1LbNt1dBsB496WXvIrXF5BoyhusA6Dd5E?usp=sharing

            //Einlesen der Tage
            int tage = Tage_Einlesen();

            //Einlesen der kaputten Teile
            int[] kaputte_Teile = kaputte_Teile_Einlesen(tage);

            //Leere Zeile
            Console.WriteLine(" ");

            //Aufgabe a: Berechnen des durchschnittlichen Wertes
            double durchschnitt = Durchschnitt_Array(kaputte_Teile);
            Console.WriteLine("Die durchschnittliche Anzahl beträgt: " + durchschnitt);

            //Aufgabe b: Kontrollieren welche Anzahlen unter dem Durschnitt liegen
            string werte_unter_dem_durchschnitt = Werte_unter_dem_Durchschnitt(kaputte_Teile, durchschnitt);
            Console.WriteLine(werte_unter_dem_durchschnitt);

            //Aufgabe c & d: Zahl welche am Häufigsten vorkommt und wie oft diese vorkommt
            string Haufige_Zahl_ergebnis = Haufige_Zahl(kaputte_Teile);
            Console.WriteLine(Haufige_Zahl_ergebnis);
        }
    }
}
