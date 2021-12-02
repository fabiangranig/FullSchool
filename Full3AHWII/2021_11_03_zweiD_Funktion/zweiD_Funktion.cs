using System;

namespace zweiD_Funktion
{
    class Program
    {
        static int[,] Einlesen()
        {
            //Deklarieren des Elementes
            int[,] zahlentabelle = new int[3, 4];

            //Mithilfe 2 for-Schleifen die Werte einlesen:
            for (int zaehler = 0; zaehler < 3; zaehler++)
            {
                for(int zaehler2 = 0; zaehler2 < 4; zaehler2++)
                {
                    Console.Write("Geben Sie bei der {0}.Zeile in der {1}.Spalte den Wert ein: ", zaehler+1, zaehler2+1);
                    zahlentabelle[zaehler, zaehler2] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Den Wert zurückgeben
            return zahlentabelle;
        }

        static void Ausgabe(int[,] zahlentabelle)
        {
            //Mithilfe der for-Schleife ausgeben
            for(int zaehler = 0; zaehler < 3; zaehler++)
            {
                for(int zaehler2 = 0; zaehler2 < 4; zaehler2++)
                {
                    //Ausgabe
                    Console.Write("{0}\t", zahlentabelle[zaehler,zaehler2]);
                }
                Console.WriteLine(" ");
            }
        }

        static void Main(string[] args)
        {
            //Aufrufen der Funktion Einlesen
            int[,] zahlentabelle = Einlesen();

            //Leere Zeile
            Console.WriteLine(" ");

            //Aufrufen der Funktion Ausgeben
            Ausgabe(zahlentabelle);

            //Das die Konsole offen bleibt
            Console.ReadLine();
        }
    }
}
