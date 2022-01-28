//Fabian Granig 3AHWII
//24.01.2022
//Lehrbeispiel zu Klassen
using System;

namespace _20220124_Klassen
{
    class Vektor2D
    {
        //Klassenvariablen, Elemente
        public double x;
        public double y;

        //Konstruktoren
        public Vektor2D()
        {
            this.x = 0;
            this.y = 0;
        }

        public Vektor2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //Methode Eingabe
        public void Eingabe(double xa, double ya)
        {
            //Zuweisung der Werte
            this.x = xa;
            this.y = ya;
        }

        //Methode Ausgabe
        public void Ausgabe()
        {
            Console.WriteLine("Werte für x,y: {0},{1}", this.x, this.y);
        }

        //Methode Add (Addieren eines Vektors)
        public Vektor2D Add(Vektor2D A)
        {
            //Einen Ergebnis Vektor2D erstellen
            Vektor2D ergebnis = new Vektor2D();

            //Aufaddieren der Werte in den Ergebnis Vektor2D
            ergebnis.x = this.x + A.x;
            ergebnis.y = this.y + A.y;

            //Den Ergebnis Punkt2D zurückgeben
            return ergebnis;
        }

        //Methode Sub (Subtrahieren eines Vektors)
        public Vektor2D Sub(Vektor2D A)
        {
            //Einen Ergebnis Vektor2D erstellen
            Vektor2D ergebnis = new Vektor2D();

            //Subtrahieren der Werte in den Ergebnis Vektor2D
            ergebnis.x = this.x - A.x;
            ergebnis.y = this.y - A.y;

            //Den Ergebnis Punkt2D zurückgeben
            return ergebnis;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Objekt der Klasse Vektor2D erstellen
            Vektor2D V1;
            V1 = new Vektor2D(3, 4);

            //Ausgabe der zugewiesenen Werte
            Console.WriteLine("Werte von V1 mit normaler Ausgabe:");
            Console.WriteLine("Der Wert x ist: {0}", V1.x);
            Console.WriteLine("Der Wert y ist: {0}", V1.y);

            //leere Zeile
            Console.WriteLine("");

            //Ausgabe mit Hilfe der Methoder der Klasse
            Console.WriteLine("Werte von V1 mit Methoden Ausgabe:");
            V1.Ausgabe();

            //leere Zeile
            Console.WriteLine("");

            //eine weitere Instanz von Vektor2D erstellen
            Vektor2D V2 = new Vektor2D();

            //Hinzufügen eines Wertes bei V2
            V2.Eingabe(5, 3);

            //Ausgabe mit Hilfe der Methode
            Console.WriteLine("Werte von V2 mit Methoden Ausgabe:");
            V2.Ausgabe();

            //leere Zeile
            Console.WriteLine("");

            //Addition von V1 und V2
            Console.WriteLine("Summe von V1 und V2:");
            Vektor2D summe = V1.Add(V2);
            summe.Ausgabe();

            //leere Zeile
            Console.WriteLine("");

            //Differenz von V1 und V2
            Console.WriteLine("Differenz von V1 und V2:");
            Vektor2D Differenz = V1.Sub(V2);
            Differenz.Ausgabe();
        }
    }
}
