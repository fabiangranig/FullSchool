using System;

namespace _20220314_Buchverwaltung
{   
    //Klasse Buch
    class Buch
    {
        //Variablen von Buch
        private int buchNr;
        private string titel;
        private string autor;
        private int anzahl;
        private double stueckpreis;
        private double umsatz = 0;

        //Static Variablen
        private static double gesamtumsatz = 0;
        private static int verkauft_anzahl = 0;
        private static int geliefert_anzahl = 0;

        //Kapselung static
        public static double Gesamtumsatz
        {
            get { return gesamtumsatz; }
        }
        public static int Verkauft_anzahl
        {
            get { return verkauft_anzahl; }
        }
        public static int Geliefert
        {
            get { return geliefert_anzahl; }
        }

        //Standartkonstruktor
        public Buch()
        {
            this.buchNr = -1;
            this.titel = "";
            this.autor = "";
            this.anzahl = 0;
            this.stueckpreis = 0;
        }

        //Konstruktor mit Variablen
        public Buch(int buchnr1, string titel1, string autor1, int anzahl1, double stueckpreis1)
        {
            this.buchNr = buchnr1;
            this.titel = titel1;
            this.autor = autor1;
            this.anzahl = anzahl1;
            this.stueckpreis = stueckpreis1;
        }

        //Methoden Anzeigen
        public void Anzeigen()
        {
            //Ausgabe
            Console.WriteLine("Die BuchNr lautet: " + this.buchNr);
            Console.WriteLine("Der Titel des Buches lautet: " + this.titel);
            Console.WriteLine("Der Autor des Buches heißt: " + this.autor);
            Console.WriteLine("Es gibt noch {0}.Stück von diesem Buch.", this.anzahl);
            Console.WriteLine("Kosten für das Buch: " + Math.Round(this.stueckpreis, 2));
        }

        //Methode Verkaufen
        public void Verkaufen(int anzahl)
        {
            if(this.anzahl - anzahl > 0)
            {
                //Ein Exemplar entfernen
                this.anzahl -= anzahl;
                
                //Umsatz hinzufügen
                this.umsatz += (anzahl * this.stueckpreis);
                gesamtumsatz += (anzahl * this.stueckpreis);

                //Wie oft verkauft wurde um eins erhöhen
                verkauft_anzahl++;
            }
        }

        //Methode Lieferung
        public void Lieferung(int anzahl)
        {
            //Die gelieferten Bücher zur Anzahl hinzufügen
            this.anzahl += anzahl;

            //Die gelieferte Anzahl erhöhen
            geliefert_anzahl++;
        }

        //Methode Lagerumsatz
        public double Lagerumsatz()
        {
            //Den Wert zurückgeben
            return Math.Round(this.umsatz, 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //zehn verschiedene Bücher anlegen
            Buch[] buecher = new Buch[10];

            //Mithilfe der for-Schleife die Bücher anlegen
            //Test Variablen
            int buchNr2 = 1;
            string titel2 = "a";
            string autor2 = "b";
            int anzahl2 = 5;
            double stueckpreis2 = 1.2;
            for(int i = 0; i < buecher.Length; i++)
            {
                //Mit Konstruktor Werte zuweisen
                buecher[i] = new Buch(buchNr2, titel2, autor2, anzahl2, stueckpreis2);

                //Test Variablen erweitern
                buchNr2 += 1;
                titel2 += "a";
                autor2 += "b";
                anzahl2 += 5;
                stueckpreis2 += 1.2;
            }

            //Anzeigen von Buch 3
            buecher[2].Anzeigen();

            //leere Zeile
            Console.WriteLine();

            //Anzeigen von Buch 4
            buecher[3].Anzeigen();

            //leere Zeile
            Console.WriteLine("");

            //Verkauf von Buch 4
            Console.WriteLine("Von Buch 4 werden 2 Exemplare verkauft.");
            buecher[3].Verkaufen(2);

            //leere Zeile
            Console.WriteLine("");

            //Buch 3 erhält eine Leiferung
            Console.WriteLine("Buch 3 erhält eine Lieferung von 3 Exemplaren.");
            buecher[2].Lieferung(3);

            //leere Zeile
            Console.WriteLine("");

            //Verkauf von Buch 3
            Console.WriteLine("Von Buch 3 werden 4 Examplare verkauft.");
            buecher[2].Verkaufen(4);
            Console.WriteLine();

            //Beide Bücher anzeigen
            buecher[2].Anzeigen();
            Console.WriteLine("");
            buecher[3].Anzeigen();

            //leere Zeile
            Console.WriteLine("");

            //Umsatz des Buches anzeigen
            Console.WriteLine("Der Umsatz des 3.Buches beträgt: " + buecher[2].Lagerumsatz());

            //leere Zeile
            Console.WriteLine();

            //Umsatz aller Bücher anzeigen
            Console.WriteLine("Der Umsatz aller Bücher beträgt: " + Math.Round(Buch.Gesamtumsatz, 2));

            //leere Zeile
            Console.WriteLine();

            //Wie oft wurden Bücher verkauft und wie oft wurden Sie verkauft
            Console.WriteLine("So oft wurde verkauft: " + Buch.Verkauft_anzahl);
            Console.WriteLine("So oft wurde geliefert: " + Buch.Geliefert);
        }
    }
}
