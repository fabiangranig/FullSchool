//3AHWII Granig
//27.09.2021
//Funktion1
using System;

namespace Funktion1
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
            while(zahl>0)
            {

            }

            //Ausgabe des Ergebnisses
            return ergebnis;
        }

        static int[] Einlesen(int anzahl)
        {
            //Mithilfe der for-Schleife die Werte einlesen
            int[] array = new int[anzahl];
            for(int zaehler = 0; zaehler < anzahl; zaehler++)
            {
                //Eingabe erstellen
                Console.Write("Geben Sie den {0}.Wert ein: ", zaehler + 1);
                array[zaehler] = Convert.ToInt32(Console.ReadLine());
            }

            return array;
        }

        static int array_summe(int[] array)
        {
            //Deklarieren einen Platz für die Summe
            int summe = 0;

            //Mit einer for-Schleife die Werte zusammenzählen
            for(int zaehler = 0; zaehler < array.Length; zaehler++)
            {
                summe += array[zaehler];
            }

            //Den Wert zurückgeben
            return summe;
        }

        static void Ausgabe_Array(int[] array)
        {
            //Mithilfe der for-Schleife alle Werte ausgeben
            for(int zaehler = 0; zaehler < array.Length; zaehler++)
            {
                Console.WriteLine("Der {0}.Wert beträgt: {1}", zaehler+1, array[zaehler]);
            }
        }

        static string groessteZahl_welchesarray(int[] array)
        {
            int ergebnis = array[0];
            string ergebnis_string = "1.Array";
            int array_counter = 0;

            //Mithilfe der for-Schleife kontrollieren welcher Wert am größten ist
            for(int zaehler = 1; zaehler < array.Length; zaehler++)
            {
                if (array[zaehler] == ergebnis)
                {
                    array_counter = zaehler + 1;
                    ergebnis_string += " / " + array_counter + ".Array";
                }

                if (array[zaehler] > ergebnis)
                {
                    ergebnis = array[zaehler];
                    array_counter = zaehler + 1;
                    ergebnis_string = array_counter + ".Array";
                }
            }

            return ergebnis_string;
        }

        static void Main(string[] args)
        {
            //Aufgabe 1
            //Eingabe der Ziffernsumme
            Console.Write("Bitte geben Sie die Zahl ein mit welcher Sie die Ziffernsumme berechnen wollen: ");
            int eingabe1 = Convert.ToInt32(Console.ReadLine());

            //Ausgabe der Ziffernsumme mit Kontrolle ob der String nicht größer als 8 ist
            if(Convert.ToString(eingabe1).Length < 9)
            {
                Console.WriteLine("Die Ziffernsumme lautet: " + Ziffernsumme(eingabe1) + "\n");
            }
            else
            {
                Console.WriteLine("Die Zahl ist länger als 8. \n");
            }
            
            
            //Aufgabe 2
            //Einlesen der Arrays
            int[] array1 = Einlesen(3);
            Console.WriteLine(" ");
            int[] array2 = Einlesen(3);
            Console.WriteLine(" ");
            int[] array3 = Einlesen(3);

            //Leere Zeile
            Console.WriteLine(" ");

            //Ausgabe aller Arrays
            Ausgabe_Array(array1);
            Ausgabe_Array(array2);
            Ausgabe_Array(array3);

            //Leere Zeile
            Console.WriteLine(" ");

            //Bei allen Arrays die Summe bilden
            int[] array_summen = new int[3];
            array_summen[0] = array_summe(array1);
            array_summen[1] = array_summe(array2);
            array_summen[2] = array_summe(array3);

            //Ausgaben von welchen Array die Summe am größten ist
            Console.WriteLine("In diesen Array/Arrays ist die Summe am Größten: {0}", groessteZahl_welchesarray(array_summen));


            //Aufgabe 3
            
        }
    }
}
