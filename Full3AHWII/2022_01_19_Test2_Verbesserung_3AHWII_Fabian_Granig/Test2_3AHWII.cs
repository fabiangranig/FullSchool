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
            public int Nenner;
            public int Zaehler;
        }

        //Funktion Eingabe
        static Bruch Eingabe(int Nenner, int Zaehler)
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
            //Wenn der Zähler 0 ist soll zusätzlich noch ein Hinweis ausgegeben werden
            if(bruch.Zaehler == 0)
            {
                //Hier wird der Bruch ausgegeben mit dem Hinweis das er 0 ist
                Console.WriteLine("Der Bruch lautet: {0}/{1} bzw. 0", bruch.Zaehler, bruch.Nenner);
            }
            else
            {
                //Hier wird der Bruch ausgegeben wenn er nicht 0 ist
                Console.WriteLine("Der Bruch lautet: {0}/{1}", bruch.Zaehler, bruch.Nenner);
            }
        }

        //Funktion Wert: Wandelt den Bruch in eine Kommazahl umwandeln
        static double Wert(Bruch bruch)
        {
            //Die Berechnung durchführen
            double wert = bruch.Zaehler / bruch.Nenner * 1.0;

            //Den Wert zurückgeben
            return wert;
        }

        //Funktion Addieren
        static Bruch Add(Bruch bruch1, Bruch bruch2)
        {
            //Ergebnis Bruch
            Bruch bruch_ergebnis;
            
            //Die beiden Nenner so multiplizieren das man den gleichen Nenner hat
            int gleicher_nenner = bruch1.Nenner * bruch2.Nenner;
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
            int gleicher_nenner = bruch1.Nenner * bruch2.Nenner;
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

            //Mit einer for-Schleife durchgehen und Kürzen, dabei sollte man beim Zähler anfangen
            for(int i = Convert.ToInt32(bruch.Zaehler); i > 0; i--)
            {
                //Nur kürzen wenn beides kürzbar ist
                if(bruch.Zaehler % i == 0 && bruch.Nenner % i == 0)
                {
                    bruch.Zaehler /= i;
                    bruch.Nenner /= i;
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
            int zaehler1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitte geben Sie den 1.Nenner ein: ");
            int nenner1 = Convert.ToInt32(Console.ReadLine());

            //leere Zeile
            Console.WriteLine("");

            //Eingabe2
            Console.WriteLine("Zuerst starten wir mit der Eingabe");
            Console.Write("Bitte geben Sie den 2.Zähler ein: ");
            int zaehler2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitte geben Sie den 2.Nenner ein: ");
            int nenner2 = Convert.ToInt32(Console.ReadLine());

            //leere Zeile
            Console.WriteLine("");

            //Die Werte nun in ein Bruch einfügen
            Bruch bruch1 = Eingabe(nenner1, zaehler1);
            Bruch bruch2 = Eingabe(nenner2, zaehler2);

            //Ausgabe
            Console.WriteLine("Ausgabe des Bruches 1: ");
            Ausgabe(bruch1);
            Console.WriteLine("In Dezimal ist der Wert: {0}", Wert(bruch1));

            //leere Zeile
            Console.WriteLine("");

            //Ausgabe2
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

            //drei leere Zeilen
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            //Ausgabe der Zusatzaufgabe
            Console.WriteLine("Hier startet die Zusatzaufgabe vom 19.01.2022:");

            //Erstellen von 5 Brüchen in einer for-Schleife
            Bruch[] bruch_array = new Bruch[5];
            for(int i = 0; i < bruch_array.Length; i++)
            {
                //Eingabe
                Console.Write("Bitte geben Sie den {0}.Zähler ein: ", i+1);
                int bruch_zaehler = Convert.ToInt32(Console.ReadLine());
                Console.Write("Bitte geben Sie den {0}.Nenner ein: ", i+1);
                int bruch_nenner = Convert.ToInt32(Console.ReadLine());

                //die Werte in die Variable Bruch einfügen
                bruch_array[i] = Eingabe(bruch_nenner, bruch_zaehler);
            }

            //Summe der fuenf Brueche berechnen
            Bruch bruch_ergebnis = bruch_array[0];
            for(int i = 1; i < bruch_array.Length; i++)
            {
                //Die Summe mit der Funktion Add berechnen
                bruch_ergebnis = Add(bruch_ergebnis, bruch_array[i]);
            }

            //leere Zeile
            Console.WriteLine("");

            //Ausgabe des Bruches
            Console.WriteLine("Das Ergebnis der 5 addierten Brüche: ");
            Ausgabe(Kuerzen(bruch_ergebnis));
        }
    }
}
