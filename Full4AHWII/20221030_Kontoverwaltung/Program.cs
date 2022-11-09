using System;

namespace _20221028_Kontoverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            //Konten erstellen
            Konto[] konten_array = new Konto[10];
            for(int i = 0; i < 5; i++)
            {
                konten_array[i] = new Studentenkonto(100 + i, 100 * (i + 1), (i + 1), 2);
                konten_array[i + 5] = new Gehaltskonto(100 + i + 5, 200 * (i + 1), (i + 5), 5);
            }

            //Alle Konten ausgeben
            for(int i = 0; i < konten_array.Length; i++)
            {
                Console.WriteLine(konten_array[i].ToString());
            }

            //leere Zeile
            Console.WriteLine("");

            //von allen Konten 10 Euro abbuchen und 20 Euro aufbuchen
            for(int i = 0; i < konten_array.Length; i++)
            {
                konten_array[i].Abbuchen(10);
                konten_array[i].Aufbuchen(20);
            }

            //Alle Konten ausgeben
            for (int i = 0; i < konten_array.Length; i++)
            {
                Console.WriteLine(konten_array[i].ToString());
            }

            //leere Zeile
            Console.WriteLine();

            //Gesamtkontostand aller Konten berechnen
            double summe = 0;
            for(int i = 0; i < konten_array.Length; i++)
            {
                summe += konten_array[i].KontostandAnzeigen();
            }
            Console.WriteLine("Der Gesamtkontostand aller Konten beträgt: " + summe);
        }
    }
}
