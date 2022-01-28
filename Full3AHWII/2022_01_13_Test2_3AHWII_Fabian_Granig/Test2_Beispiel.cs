//Granig Fabian 3AHWII
//12.01.2021
//Beispiel: Test2
using System;

namespace T2_Granig_Fabian
{
    class Program
    {
        //Struct Bruch implementieren
        struct Bruch
        {
            public double Nenner;
            public double Zaehler;
        }

        //Funktion Eingabe
        static Bruch Eingabe(double Nenner, double Zaehler)
        {
            //Erstellen eines Bruchs
            Bruch bruch;

            //Die Werte zuweisen
            bruch.Nenner = Nenner;
            bruch.Zaehler = Zaehler;

            //Den Bruch zurückgeben
            return bruch;
        }

        //Funktion Ausgabe
        static void Ausgabe(Bruch bruch)
        {
            //Den Bruch ausgeben
            Console.WriteLine("Der Bruch lautet: {0}/{1}", bruch.Zaehler, bruch.Nenner);
        }

        //Funktion Wert: Wandelt den Bruch in eine Kommazahl umwandeln
        static double Wert(Bruch bruch)
        {
            //Die Berechnung durchführen
            double wert = bruch.Zaehler / bruch.Nenner;

            //Den Wert zurückgeben
            return wert;
        }

        //Funktion Addieren
        static Bruch Add(Bruch bruch1, Bruch bruch2)
        {
            //Ergebnis Bruch
            Bruch bruch_ergebnis;
            
            //Die beiden Nenner so multiplizieren das man den gleichen Nenner hat
            double gleicher_nenner = bruch1.Nenner * bruch2.Nenner;
            bruch1.Zaehler = bruch1.Zaehler * bruch2.Nenner;
            bruch2.Zaehler = bruch2.Zaehler * bruch1.Nenner;

            //Addieren der Zaehler Werte
            bruch_ergebnis.Zaehler = bruch1.Zaehler + bruch2.Zaehler;
            bruch_ergebnis.Nenner = gleicher_nenner;

            //Das Ergebnis zurückgeben
            return bruch_ergebnis;
        }

        //Funktion Subtrahieren
        static Bruch Sub(Bruch bruch1, Bruch bruch2)
        {
            //Ergebnis Bruch
            Bruch bruch_ergebnis;

            //Die beiden Nenner so multiplizieren das man den gleichen Nenner hat
            double gleicher_nenner = bruch1.Nenner * bruch2.Nenner;
            bruch1.Zaehler = bruch1.Zaehler * bruch2.Nenner;
            bruch2.Zaehler = bruch2.Zaehler * bruch1.Nenner;

            //Subtrahieren der Zaehler Werte
            bruch_ergebnis.Zaehler = bruch1.Zaehler - bruch2.Zaehler;
            bruch_ergebnis.Nenner = gleicher_nenner;

            //Das Ergebnis zurückgeben
            return bruch_ergebnis;
        }

        //Funktion Multiplikation
        static Bruch Multiplikation(Bruch bruch1, Bruch bruch2)
        {
            //Erstellen eines Ergebnis Bruches
            Bruch bruch_ergebnis;

            //Multiplizieren der Zahlen
            bruch_ergebnis.Zaehler = bruch1.Zaehler * bruch2.Zaehler;
            bruch_ergebnis.Nenner = bruch1.Nenner * bruch2.Nenner;

            //Das Ergebnis zurückgeben
            return bruch_ergebnis;
        }

        //Funktion Kürzen
        static Bruch Kuerzen(Bruch bruch)
        {
            //Ergebnis Bruch
            Bruch bruch_ergebnis;

            //Mit einer while-Schleife durchgehen und mit 2 Kürzen oder dem Zähler
            for(int i = 2; i < 10; i++)
            {
                while (bruch.Zaehler % i == 0 && bruch.Nenner % i == 0)
                {
                    bruch.Zaehler /= i;
                    bruch.Nenner /= i;
                }

                //Backup falls noch kürzen möglich wäre
                if(i == 9)
                {
                    for(int i2 = 2; i2 < 10; i2++)
                    {
                        if(bruch.Zaehler % i2 == 0 && bruch.Nenner % i2 == 0)
                        {
                            i = 2;
                        }
                    }
                }
            }

            //Die Werte in den Ergebnis Bruch
            bruch_ergebnis.Zaehler = bruch.Zaehler;
            bruch_ergebnis.Nenner = bruch.Nenner;

            //Den Wert zurückgeben
            return bruch_ergebnis;
        }

        static void Main(string[] args)
        {
            //Angabe
            Console.WriteLine("Dieses Programm führt Berechnungen mit Brüchen durch: ");

            //Eingabe
            Console.WriteLine("Zuerst starten wir mit der Eingabe");
            Console.Write("Bitte geben Sie den 1.Zähler ein: ");
            double zaehler1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Bitte geben Sie den 1.Nenner ein: ");
            double nenner1 = Convert.ToDouble(Console.ReadLine());

            //leere Zeile
            Console.WriteLine("");

            //Eingabe2
            Console.WriteLine("Zuerst starten wir mit der Eingabe");
            Console.Write("Bitte geben Sie den 2.Zähler ein: ");
            double zaehler2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Bitte geben Sie den 2.Nenner ein: ");
            double nenner2 = Convert.ToDouble(Console.ReadLine());

            //leere Zeile
            Console.WriteLine("");

            //Die Werte nun in ein Bruch einfügen
            Bruch bruch1 = Eingabe(nenner1, zaehler1);
            Bruch bruch2 = Eingabe(nenner2, zaehler2);

            //Ausgabe
            Console.WriteLine("Ausgabe des Bruches 1: ");
            Ausgabe(bruch1);
            Console.WriteLine("In Dezimal ist der Wert: {0}", Wert(bruch1));
            Console.WriteLine("Ausgabe des Bruches 2: ");
            Ausgabe(bruch2);
            Console.WriteLine("In Dezimal ist der Wert: {0}", Wert(bruch2));

            //leere Zeile
            Console.WriteLine("");

            //Addieren
            Bruch bruch_summe = Add(bruch1, bruch2);
            Console.WriteLine("Addition der zwei Brüche: ");
            Ausgabe(Kuerzen(bruch_summe));

            //leere Zeile
            Console.WriteLine("");

            //Subtraktion
            Bruch bruch_subtraktion = Sub(bruch1, bruch2);
            Console.WriteLine("Subtraktion der zwei Brüche: ");
            Ausgabe(Kuerzen(bruch_subtraktion));

            //leere Zeile
            Console.WriteLine("");

            //Multiplikation
            Bruch bruch_multiplikation = Multiplikation(bruch1, bruch2);
            Console.WriteLine("Multiplikation der zwei Brüche: ");
            Ausgabe(Kuerzen(bruch_multiplikation));
        }
    }
}
