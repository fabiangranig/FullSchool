using System;

namespace _20220926_Boot_Ableitung
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boot erstellen
            CSegelboot segelboot1 = new CSegelboot(10, 2, 5, "Boot1", 10, 5, 2, 10000, 200, 10);

            //Alle Infos Anzeigen
            segelboot1.Anzeigen();

            //leere Zeile
            Console.WriteLine("");

            //Segel schließen, Boot beladen (+100) und Segel öffnen
            Console.WriteLine("Info: Segel schließen, Boot beladen (+100) und Segel öffnen");
            segelboot1.SegelFlaecheAendern(false);
            segelboot1.Zu_oder_entladen(100);
            segelboot1.SegelFlaecheAendern(true);

            //leere Zeile
            Console.WriteLine();

            //Informationen anzeigen
            segelboot1.Anzeigen();
        }
    }
}
