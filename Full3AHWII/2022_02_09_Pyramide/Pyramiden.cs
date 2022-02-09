//Fabian Granig 3AHWII
//09.02-2022
//Beispiel: Pyramide
using System;

namespace _20220209_Pyramide
{
    class Pyramide
    {
        //Variablen der Klasse
        public double laenge;
        public double breite;
        public double hoehe;

        //Standartkonstruktor
        public Pyramide()
        {
            this.laenge = 0;
            this.breite = 0;
            this.hoehe = 0;
        }

        //einen Wert Konstruktor
        public Pyramide(double eingabe)
        {
            this.laenge = eingabe;
            this.breite = eingabe;
            this.hoehe = eingabe;
        }

        //zwei Wert Konstruktor
        public Pyramide(double seite1, double hoehe1)
        {
            this.laenge = seite1;
            this.breite = seite1;
            this.hoehe = hoehe1;
        }

        //drei Werte Konstruktor
        public Pyramide(double laenge1, double breite1, double hoehe1)
        {
            this.laenge = laenge1;
            this.breite = breite1;
            this.hoehe = hoehe1;
        }

        //Methode Ändern
        public void Ändern(double laenge1, double breite1, double hoehe1)
        {
            this.laenge = laenge1;
            this.breite = breite1;
            this.hoehe = hoehe1;
        }

        //Methode Anzeigen
        public void Anzeigen()
        {
            Console.WriteLine("Die Länge beträgt: " + this.laenge);
            Console.WriteLine("Die Breite beträgt: " + this.breite);
            Console.WriteLine("Die Höhe beträgt: " + this.hoehe);
        }

        //Methode Volumen
        public double Volumen()
        {
            //Berechnung mit Formel
            double ergebnis = (this.laenge * this.breite) * this.hoehe / 3;

            //Das Ergebnis zurückgeben
            return ergebnis;
        }

        //Methode Oberfläche
        public double Oberfläche()
        {
            //Berechnung von den zwei Seitenkanten
            double sa = Math.Sqrt(Math.Pow(this.hoehe, 2) + Math.Pow((this.laenge / 2), 2));
            double sb = Math.Sqrt(Math.Pow(this.hoehe, 2) + Math.Pow((this.breite / 2), 2));

            //Berechnung der Seiten Oberfläche
            double a_flaeche = this.laenge * sa;
            double b_flaeche = this.breite * sb;

            //Berechnung der Bodenfläche
            double bodenflaeche = this.laenge * this.breite;

            //Berechnung der Formel
            double ergebnis = a_flaeche + b_flaeche + bodenflaeche;

            //Das Ergebnis zurückgeben
            return ergebnis;
        }

        //Methode Vergleichen
        public int Vergleichen(Pyramide py2)
        {
            //Von beiden die Fläche berechnnen
            double py1_flaeche = Oberfläche();
            double py2_flaeche = py2.Oberfläche();

            //Checken welche Fläche die größte ist
            if(py1_flaeche > py2_flaeche)
            {
                return 1;
            }
            else
            {
                if(py2_flaeche > py1_flaeche)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        //Methode IstQuadratische
        public bool IstQuadratische()
        {
            if(this.laenge == this.breite && this.breite == this.hoehe)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Array mit 6 Pyramiden
            Pyramide[] pyramides = new Pyramide[6];

            //Einlesen der Seiten der Pyramide
            for(int i = 0; i < pyramides.Length; i++)
            {
                //Eingabe
                Console.Write("Geben Sie bitte die Länge der {0}.Pyramide ein: ", i+1);
                double laenge = Convert.ToDouble(Console.ReadLine());
                Console.Write("Geben Sie bitte die Breite der {0}.Pyramide ein: ", i + 1);
                double breite = Convert.ToDouble(Console.ReadLine());
                Console.Write("Geben Sie bitte die Hoehe der {0}.Pyramide ein: ", i + 1);
                double hoehe = Convert.ToDouble(Console.ReadLine());

                //Bauen mit Konstruktor
                pyramides[i] = new Pyramide(laenge, breite, hoehe);
            }

            //leere Zeile
            Console.WriteLine();

            //Kontrollieren wieviele davon Quadratisch sind
            int zaehler = 0;
            for(int i = 0; i < pyramides.Length; i++)
            {
                if(pyramides[i].IstQuadratische())
                {
                    zaehler++;
                }
            }

            //Ausgabe der Quadratischen Pyramiden
            Console.WriteLine("Es sind {0} Pyramiden quadratisch.", zaehler);

            //Gesamtes Volumen aller Pyaramiden
            double volumen = 0;
            for(int i = 0; i < pyramides.Length; i++)
            {
                volumen += pyramides[i].Volumen();
            }

            //Ausgabe des gesamten Volumens
            Console.WriteLine("Das Volumen aller Pyramiden beträgt: " + volumen);

            //Welche Pyramide besitzt die größte Fläche
            Pyramide highest = pyramides[0];
            int zaehler2 = 0;
            for(int i = 1; i < pyramides.Length; i++)
            {
                //Vergleichen
                if(highest.Vergleichen(pyramides[i]) == -1)
                {
                    highest = pyramides[i];
                    zaehler2 = i;
                }
            }

            //leere Zeile
            Console.WriteLine();

            //Die größte Pyramide ausgeben
            int zaehler3 = zaehler2 + 1;
            Console.WriteLine("Die größte Pyramide ist " + zaehler3 + " mit den Werten: ");
            pyramides[zaehler2].Anzeigen();
        }
    }
}
