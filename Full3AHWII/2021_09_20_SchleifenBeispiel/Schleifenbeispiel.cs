//3AHWII Granig
//20.09.2021
//String Arrays
using System;
using System.IO;
using System.Collections.Generic;

namespace Beispiel_Schleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarieren des Arrays
            int name_anzahl = 3;
            string[] name = new string[name_anzahl];
            string[] name2 = new string[name_anzahl];

            //Ergenisse Strings
            string[] zusammengefuegte_namen = new string[name_anzahl];
            string zusammengefuegte_namen_ausgabe = "\n";
            string namen_die_weniger_als_12_buchstaben_haben = "\nFolgende Namen haben weniger als 12 Buchstaben: \n";
            string namen_welche_mit_Ku_beginnen = "\nDiese Namen beginnen mit Ku: \n";
            string alphabet_text = "\nAm weitesten vorne im Alphabet ist: ";
            string endstring = "";

            //for-Schleife für alle Aufgaben
            for (int zaehler = 0; zaehler < name_anzahl; zaehler++)
            {
                //zaehler + 1
                int zaehler_plus_eins = zaehler + 1;
                
                //Vorname einlesen
                Console.Write("Geben Sie bitte den {0}.Vornamen ein: ", zaehler + 1);
                name[zaehler] = Convert.ToString(Console.ReadLine());

                //Nachnamen einlesen
                Console.Write("Geben Sie bitte den {0}.Nachnamen ein: ", zaehler + 1);
                name2[zaehler] = Convert.ToString(Console.ReadLine());

                //Namen zusammenführen
                zusammengefuegte_namen[zaehler] = name[zaehler] + " " + name2[zaehler];
                zusammengefuegte_namen_ausgabe += zaehler_plus_eins + ".Name: " + zusammengefuegte_namen[zaehler] + "\n";

                //Aufgabe a)
                //Mit einer if-Schleife checken ob der String kleiner als 12 Buchstaben ist
                if (zusammengefuegte_namen[zaehler].Length < 13)
                {
                    namen_die_weniger_als_12_buchstaben_haben += zusammengefuegte_namen[zaehler] + "\n";
                }

                //Aufgabe b)
                //Mit einer if-Anweisung checken ob ein Name mit "Ku" anfängt
                if (zusammengefuegte_namen[zaehler].IndexOf("Ku") == 0)
                {
                    namen_welche_mit_Ku_beginnen += zusammengefuegte_namen[zaehler] + "\n";
                }

                //Aufgabe c)
                //Mithilfe von String Compare checken welcher String der Größte ist
                if (zaehler == 0)
                {
                    endstring = zusammengefuegte_namen[zaehler];
                }

                if (String.Compare(zusammengefuegte_namen[zaehler], endstring) == -1 && zaehler != 0)
                {
                    endstring = zusammengefuegte_namen[zaehler];
                }
            }

            //Ausgabe
            Console.WriteLine(zusammengefuegte_namen_ausgabe + namen_die_weniger_als_12_buchstaben_haben + namen_welche_mit_Ku_beginnen + alphabet_text + endstring);
        }
    }
}
