//Fabian Granig 3AHWII
//24.01.2022
//Klasse: Rechteck Kapelung
using System;

namespace _20220124_Klasse_Rechteck
{
    class Rechteck
    {
        //Variablen anlegen
        private double laenge;
        private double breite;

        //Kapselung
        public double Laenge
        {
            get { return laenge; }
            set { laenge = value; }
        }

        public double Breite 
        {
            get { return breite; }
            set { breite = value; }
        }

        //Konstruktoren
        //Standart Konstruktor
        public Rechteck()
        {
            this.laenge = 0;
            this.breite = 0;
        }

        //Konstruktor zum Zuweisen von Werten
        public Rechteck(int alaenge, int abreite)
        {
            this.laenge = alaenge;
            this.breite = abreite;
        }

        //Konstruktor um ein Quadrat zuzuweisen
        public Rechteck(int alaenge)
        {
            this.laenge = alaenge;
            this.breite = alaenge;
        }

        //Methode Anzeigen
        public void Anzeigen()
        {
            Console.WriteLine("Die Länge beträgt: {0}", this.laenge);
            Console.WriteLine("Die Breite beträgt: {0}", this.breite);
        }

        //Methode Ändern
        public void Aendern(double alaenge, double abreite)
        {
            //neue Werte zuweisen
            this.laenge = alaenge;
            this.breite = abreite;
        }

        //Methode Fläche
        public double flaeche()
        {
            //Berechnen und zurückgeben
            return this.laenge * this.breite;
        }

        //Methode Umfang
        public double Umfang()
        {
            //Berechnen und Wert zurückgeben
            return 2 * (this.laenge + this.breite);
        }

        //Methode Vergleichen nach Flaeche
        public int Vergleichen(Rechteck A)
        {
            //Fläche von beiden holen
            double flaeche2 = A.flaeche();
            double flaeche1 = flaeche();

            //Vergleichen
            //Wenn Fläche 1 größer ist soll 1 zurückgegeben werden
            if(flaeche1 > flaeche2)
            {
                return 1;
            }

            //Wenn Fläche 2 größer ist soll -1 zurückgegeben werden
            if(flaeche1 < flaeche2)
            {
                return -1;
            }

            //Wenn die Flächen gleich groß sind soll 0 zurückgegeben werden
            if(flaeche1 == flaeche2)
            {
                return 0;
            }

            //Wenn nichts zutrifft soll 99 zurückgegeben werden
            return 99;
        }

        //Methode Diagonale
        public double Diagonale()
        {
            //Berechnung der Diagonale und Rückgabe
            return Math.Sqrt(Math.Pow(this.laenge, 2) + Math.Pow(this.breite, 2));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Zwei Objekte erstellen
            Rechteck r1 = new Rechteck();
            Rechteck r2 = new Rechteck(2,1);

            //Die Werte anzeigen von ersten Rechteck
            Console.WriteLine("Die Maße von Rechteck 1 werden angezeigt: ");
            r1.Anzeigen();

            //leere Zeile
            Console.WriteLine("");

            //Die Werte anzeigen vom zweiten Rechteck
            Console.WriteLine("Die Maße von Rechteck 2 werden angezeigt: ");
            r2.Anzeigen();

            //Vom Rechteck sollen nun die Wert geändert werden
            r1.Aendern(3, 2);

            //leere Zeile
            Console.WriteLine("");

            //Den geänderten Wert von Rechteck 1 anzeigen
            Console.WriteLine("Rechtecks 1 geänderte Werte werden angezeigt:");
            r1.Anzeigen();

            //leere Zeile
            Console.WriteLine("");

            //Vom ersten Rechteck wird die Fläche angezeigt
            Console.WriteLine("Die Fläche vom ersten Rechteck ist: {0}", r1.flaeche());
            Console.WriteLine("Der Umfang vom ersten Rechteck beträgt: {0}", r1.Umfang());

            //Vergleichen von zwei Rechtecken nach Fläche
            int schalter = r1.Vergleichen(r2);

            //Ausgabe von Vergleichen
            switch(schalter)
            {
                case 1:
                    Console.WriteLine("Fläche 1 ist größer als Fläche 2.");
                    break;

                case -1:
                    Console.WriteLine("Fläche 2 ist größer als Fläche 1.");
                    break;

                case 0:
                    Console.WriteLine("Beide Flächen sind gleich groß.");
                    break;

                case 99:
                    Console.WriteLine("Ein Fehler ist passiert.");
                    break;

                default:
                    Console.WriteLine("Ein Fehler ist passiert.");
                    break;
            }

            //Diagonale
            Console.WriteLine("Rechteck 1 hat eine Diagonale von: {0}", r1.Diagonale());
        }
    }
}
