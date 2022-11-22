using System;

namespace Feuerwehr_XX
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array anlegen
            Mitglied[] m1 = new Mitglied[6];

            //Mitglieder anlegen
            for (int i = 0; i < m1.Length; i++)
            {
                //Feuerwehrmänner anlegen
                if ((i + 1) % 2 == 0)
                {
                    m1[i] = new Feuerwehrmann((i + 1) * 100, "Fabian" + i, "Granig" + i, new DateTime(2004 + i, 12, 1), "Funktion" + i, "Dientgrad" + i, (i + 1) * 10, (i + 1) * 60, new DateTime(2015 + i, 6, 1));
                }

                //unterstützende Mitglieder anlegen
                if ((i + 1) % 2 == 1)
                {
                    m1[i] = new unterstuetzendesMitglied((i + 2) * 1000, "Fabian" + i, "Granig" + i, new DateTime(2002 + i, 12, 1), (i + 1) * 20, new DateTime(2010 + i, 4, 4));
                }
            }

            //Ist Mitglieder anlegen möglich? Nein, daher auskommentiert
            //Mitglied m2 = new Mitglied();

            //Alle Mitglieder ausgeben
            for (int i = 0; i < m1.Length; i++)
            {
                m1[i].Mitgliedsdaten_Anzeigen();
            }

            //leere Zeile
            Console.WriteLine(" ");

            //Wie viele Jahre sind die Mitglieder durchschnittlich dabei?
            double summe = 0;
            for (int i = 0; i < m1.Length; i++)
            {
                summe += m1[i].Mitgliedsjahre();
            }
            double durchschnitt = summe / m1.Length * 1.0;
            Console.WriteLine("Durchschnittlich sind die Mitglieder " + durchschnitt + " Jahre dabei.");

            //leere Zeile
            Console.WriteLine("");

            //Zum Testen nochmal die durchschnittliche Einsatzdauer von einem ausgeben
            Feuerwehrmann f1 = new Feuerwehrmann();
            Console.WriteLine("Durchschnittliche Einsatzdauer von Test Feuerwehrmann: " + f1.DurchschnittlicheEinsatzdauer() + " Minuten");

            //Wie groß ist die Gesamteinsatzdauer aller Feuerwehrmänner? / Summe Mitgliedbeiträge berechnen
            double gesamteinsatzdauer2 = 0;
            double mitgliedsbeiträge2 = 0;
            for(int i = 0; i < m1.Length; i++)
            {
                if(m1[i] is Feuerwehrmann feuerwehrmann)
                {
                    gesamteinsatzdauer2 += feuerwehrmann.Gesamteinsatzdauer;
                }
                if (m1[i] is unterstuetzendesMitglied)
                {
                    mitgliedsbeiträge2 += (m1[i] as unterstuetzendesMitglied).Mitgliedbeitrag;
                }
            }

            //Die gesamte Einsatzdauer ausgeben
            Console.WriteLine("Die gesamte Einsatzdauer beträgt: " + gesamteinsatzdauer2);
            Console.WriteLine("Die Summe der Mitgliedbeiträge beträgt: " + mitgliedsbeiträge2);
        }
    }
}
