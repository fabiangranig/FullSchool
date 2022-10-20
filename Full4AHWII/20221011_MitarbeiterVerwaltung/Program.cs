using System;

namespace _20221011_MitarbeiterVerwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array von beiden Arten
            Mitarbeiter[] mitarbeiters = new Mitarbeiter[10];

            //Die Arrays befüllen
            for (int i = 0; i < 5; i++)
            {
                //Einlesen der Werte
                int cpo = i + 1;
                mitarbeiters[i] = new Arbeiter(cpo * 1, "Arbeiter"+cpo, "Adresse"+cpo, "Abteilung"+cpo, cpo*20, cpo*5);
                mitarbeiters[i + 5] = new Angestellter(cpo * 1 + 5, "Angestellter" + cpo, "Adresse" + cpo, "Abteilung" + cpo, cpo * 20 * 2, cpo * 1000);
            }

            //Die Werte ausgeben
            for(int i = 0; i < 10; i++)
            {
                int cpo = i + 1;

                //Ausgabe der Werte                    
                mitarbeiters[i].Personaldaten_anzeigen();
                mitarbeiters[i].Hat_Gehalt();

                Console.WriteLine(" ");
            }
        }
    }
}
