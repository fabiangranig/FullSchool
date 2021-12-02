using System;

namespace Full2AHWII
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erklärung des Programms
            Console.WriteLine("Dieses Programm ist eine Zusammenfassung aus SWP_C# aus der HTL Wolfsberg.");
            //Schalter ob die Console aktiv bliebt
            bool consoleaktiv = false;

            //Eingabe des Programms welches ausgeführt werden sollte
            while(consoleaktiv == false)
            {
                //Soll das Inhaltsverzeichnis angezeigt werden
                Console.Write("Möchtest du das Inhaltsverzeichnis ausführen (Ja / Nein)? ");
                string Inhaltsverzeichnis = Convert.ToString(Console.ReadLine());
                if (Inhaltsverzeichnis == "Ja")
                {
                    Console.WriteLine("001 - Ausgabe");
                    Console.WriteLine("002 - Freier Fall");
                    Console.WriteLine("003 - Grad in Fahrenheit");
                    Console.WriteLine("004 - Grundrechnungsarten");
                    Console.WriteLine("005 - Kilometerstand");
                    Console.WriteLine("006 - Konsolenprogramm");
                    Console.WriteLine("007 - MathClassBeispiel");
                    Console.WriteLine("008 - Meine Klasse");
                    Console.WriteLine("009 - Ostersonntag");
                    Console.WriteLine("010 - Preisermittlung");
                    Console.WriteLine("011 - Rabatt");
                    Console.WriteLine("012 - Rechteck");
                    Console.WriteLine("013 - Zahl1_gleich_Zahl2");
                    Console.WriteLine("014 - Zylinder");
                    Console.WriteLine("015 - for-Schleife-Aufgabe_a");
                    Console.WriteLine("016 - for-Schleife-Aufgabe_b");
                    Console.WriteLine("017 - While_Schleife");
                    Console.WriteLine("018 - Do-While-Schleife");
                    Console.WriteLine("019 - String Aufgabe");
                    Console.WriteLine("020 - String Aufgabe 2");
                    Console.WriteLine("021 - Array");
                    Console.WriteLine("022 - Array Extra");
                    Console.WriteLine("023 - durchschnittliche Abkühlung");
                }

                //Leere Zeile
                Console.WriteLine(" ");

                //Auswahl der Aufgabe
                Console.Write("Welche Aufgabe möchtest du aufrufen? ");
                int welcheaufgabe = Convert.ToInt32(Console.ReadLine());

                //Leere Zeile
                Console.WriteLine(" ");

                if (welcheaufgabe == 1)
                    Ausgabe();
                else
                if (welcheaufgabe == 2)
                    FreierFall();
                else
                if (welcheaufgabe == 3)
                    GradinFahrenheit();
                else
                if (welcheaufgabe == 4)
                    Grundrechnungsarten();
                else
                if (welcheaufgabe == 5)
                    Kilometerstand();
                else
                if (welcheaufgabe == 6)
                    Konsolenprogramm();
                else
                if (welcheaufgabe == 7)
                    MathClassBeispiel();
                else
                if (welcheaufgabe == 8)
                    MeineKlasse();
                else
                if (welcheaufgabe == 9)
                    Ostersonntag();
                else
                if (welcheaufgabe == 10)
                    Preisermittlung();
                else
                if (welcheaufgabe == 11)
                    Rabatt();
                else
                if (welcheaufgabe == 12)
                    Rechteck();
                else
                if (welcheaufgabe == 13)
                    Zahl1_gleich_Zahl2();
                else
                if (welcheaufgabe == 14)
                    Zylinder();
                else
                if (welcheaufgabe == 15)
                    For_Schleife_Aufgabe_a();
                else
                if (welcheaufgabe == 16)
                    For_Schleife_Aufgabe_b();
                else
                if (welcheaufgabe == 17)
                    While_Schleife();
                else
                if (welcheaufgabe == 18)
                    Do_While_Schleife();
                else
                if (welcheaufgabe == 19)
                    String_Aufgabe();
                else
                if (welcheaufgabe == 20)
                    String_Aufgabe_2();
                else
                if (welcheaufgabe == 21)
                    Array();
                else
                if (welcheaufgabe == 22)
                    Array_Extra();
                else
                if (welcheaufgabe == 23)
                    durschnittliche_Abkuehlung();

                //Leere Zeile
                Console.WriteLine(" ");

                //Ob die Console offenbleiben soll
                Console.Write("Soll die Console offen bleiben (Ja / Nein)? ");
                string consoleoffenbleiben = Convert.ToString(Console.ReadLine());

                if (consoleoffenbleiben == "Nein")
                {
                    consoleaktiv = true;
                }
            }
        }
    
        static void Ausgabe()
        {
            //Deklaration einer Variable vom Datentyp Integer
            //int: 4 Byte, ganze Zahlen, positive und negative
            int summe1;

            //Deklaration mit Intiliasierung
            int summe2 = 5;
            summe1 = 77;
            int summe3 = 22;

            //char - Dateityp
            char zeichen1 = 'A';
            char zeichen2 = 'B';
            char zeichen3 = 'C';
            char zeichen4 = 'D';

            //Wahrheitswert
            bool schalter = true;

            //reelle Zahlen 
            double dZahl = 2.6;

            //float-Zahlen müssen bei Intalisierung das Suffix f dabei haben
            float fZahl = 2.6f;


            //Ausgabe
            Console.WriteLine("Willkommen bei der SWP-Programmierung.");
            Console.WriteLine("Zeichen: {0} {1} {2} {3}", zeichen1, zeichen2, zeichen3, zeichen4);
            Console.WriteLine("Summe: {0}", summe2);
            Console.WriteLine("Summe1: {0} Summe2: {1} Summe: {2}", summe1, summe2, summe3);
            Console.WriteLine("Restliche Werte: dzahl={0} fZahl={1} schalter={2}", dZahl, fZahl, schalter);
        }
        static void FreierFall()
        {
            //Defienierung der Variablen
            double masse, querschnittsflaeche;
            double geschwindigkeit;

            //Eingabe der Masse
            Console.Write("Geben Sie die Masse ein:  ");
            masse = Convert.ToSingle(Console.ReadLine());

            //Eingabe der Querschnittsflaeche
            Console.Write("Geben Sie die Querschnittsfläche ein:  ");
            querschnittsflaeche = Convert.ToSingle(Console.ReadLine());

            //Formel zur Berechnung der Geschwindigkeit
            geschwindigkeit = 3.6 * Math.Sqrt(10 * masse / querschnittsflaeche);

            //Ausgabe des Ergebnisses
            Console.WriteLine("Die Geschwindigkeit beträgt: = {0:F2} km/h", geschwindigkeit);
        }
        static void GradinFahrenheit()
        {
            //Bezeichnung der Variable
            double fahrenheit, celsius;

            //Eingabe von Celsius
            Console.Write("Geben Sie bitte die Temperatur in Grad Celsius ein:  ");
            celsius = Convert.ToSingle(Console.ReadLine());

            //Berechnung von Fahrenheit
            fahrenheit = 9 / 5 * celsius + 32;

            //Ausgabe des Ergebnisses
            Console.WriteLine("Die Grad Celsius in Grad Fahrenheit betragen: {0:F2}", fahrenheit);
        }
        static void Grundrechnungsarten()
        {
            //Definition von Zahlen
            double zahl1, zahl2;
            double erg_add0, erg_add1, erg_add2, erg_add3;

            //Zahlen einlesen
            Console.Write("Geben Sie bitte die erste Zahl ein:  ");
            zahl1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geben sie bitte die zweite Zahl ein:  ");
            zahl2 = Convert.ToDouble(Console.ReadLine());

            //Berechnung
            erg_add0 = zahl1 + zahl2;
            erg_add1 = zahl1 - zahl2;
            erg_add2 = zahl1 * zahl2;
            erg_add3 = zahl1 / zahl2;

            //Ausgabe auf dem Bildschirm
            Console.WriteLine(zahl1 + "+" + zahl2 + "=" + erg_add0);
            Console.WriteLine(zahl1 + "-" + zahl2 + "=" + erg_add1);
            Console.WriteLine(zahl1 + "*" + zahl2 + "=" + erg_add2);
            Console.WriteLine(zahl1 + "/" + zahl2 + "=" + erg_add3);
        }
        static void Kilometerstand()
        {
            //Definierung der Variable
            float kilometer1, kilometer2, liter, treibstoff;

            //Kilometerstand vor der Fahrt eingeben
            Console.Write("Geben Sie den Kilometerstand vor der Fahrt ein:  ");
            kilometer1 = Convert.ToSingle(Console.ReadLine());

            //Kilometerstand nach der Fahrt eingeben
            Console.Write("Geben sie den Kilometerstand nach der Fahrt ein:  ");
            kilometer2 = Convert.ToSingle(Console.ReadLine());

            //Treibstoff in Liter eingeben
            Console.Write("Wieviel Liter Treibstoff haben Sie getankt?");
            liter = Convert.ToSingle(Console.ReadLine());

            //Formel zur Berechnung vom durchschnittlichen Treibstoffverbrauch
            treibstoff = liter / (kilometer2 - kilometer1) * 100;

            //Ausgabe des Ergebnis
            Console.WriteLine("Durchschnittlicher Verbrauch pro 100km = {0:F2} Liter", treibstoff);
        }
        static void Konsolenprogramm()
        {
            Console.WriteLine(@" \    ^__^");
            Console.WriteLine(@" \    (oo) \________");
            Console.WriteLine(@"     (____) \    )\/\");
            Console.WriteLine(@"          ||----w |");
            Console.WriteLine(@"          ||      ||");
        }
        static void MathClassBeispiel()
        {
            //Man muss immer "Enter" drücken um die nächste Zahl zu bekommen.

            //Abs (Absolute) Methode
            int zahl = -10;
            int absoluteZahl = Math.Abs(zahl);
            Console.WriteLine(absoluteZahl);
            Console.ReadKey();

            //Leere Zeile
            Console.WriteLine();

            //Pow (Power of x) Methode
            double zahl1 = 5;
            double exponent1 = 2;
            double ergebnis1 = Math.Pow(zahl1, exponent1);
            Console.WriteLine(ergebnis1);
            Console.ReadKey();

            //Leere Zeile
            Console.WriteLine();

            //Sign Methode
            int zahl2 = -4;
            int zahl3 = 0;
            int zahl4 = 6;

            Console.WriteLine(Math.Sign(zahl2));
            Console.WriteLine(Math.Sign(zahl3));
            Console.WriteLine(Math.Sign(zahl4));

            Console.ReadKey();

            //Leere Zeile
            Console.WriteLine();

            //PI und E anzeigen
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.E);
        }
        static void MeineKlasse()
        {
            Console.WriteLine("");
            Console.WriteLine("Mein Name ist Fabian Granig.");
            Console.WriteLine("");
            Console.WriteLine("Ich gehe in die Klasse 2AHWII.");
            Console.WriteLine("");
            Console.WriteLine("Ich wohne in Wolfsberg.");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
        static void Ostersonntag()
        {
            //Definierung der Variable
            double j;
            double a, b, c, d, e, f;
            double rest1, rest2;
            double osterdatum;

            //Eingabe der Jahreszahl
            Console.Write("Geben Sie bitte die Jahrezahl ein:  ");
            j = Convert.ToInt32(Console.ReadLine());

            //Berechnung
            a = j - 1900;
            b = a % 19;
            rest1 = (7 * b + 1) % 19;
            rest2 = rest1 / 19;
            c = ((7 * b + 1) / 19) - rest2;
            d = (11 * b + 4 - c) % 29;
            e = a / 4;
            f = (a + e + 31 - d) % 7;
            osterdatum = 25 - d - f;

            //Leere Zeile
            Console.WriteLine("");

            //Ausgabe
            Console.WriteLine("Das Osterdatum ist am {0:F0}.4.{1}", osterdatum, j);
        }
        static void Preisermittlung()
        {
            //Definierung der Variable
            double alter;

            //Eingabe des Alters
            Console.Write("Geben Sie bitte das Alter ein:  ");
            alter = Convert.ToDouble(Console.ReadLine());

            //Ausgabe des Preises
            if (alter < 6)
            {
                Console.WriteLine("Sie bezahlen nichts.");
            }

            else
            {
                if (alter < 19)
                {
                    Console.WriteLine("Sie bezahlen 5,50 Euro.");
                }

                else
                {
                    if (alter > 18)
                    {
                        Console.WriteLine("Sie bezahlen 10 Euro.");
                    }
                    else
                    {
                        Console.WriteLine("Fehler");
                    }
                }
            }
        }
        static void Rabatt()
        {
            //Definierung der Variable
            double alter;

            //Eingabe des Alters
            Console.Write("Geben Sie bitte das Alter ein:  ");
            alter = Convert.ToDouble(Console.ReadLine());

            //Ausgabe des Preises
            if (alter < 6)
            {
                Console.WriteLine("Sie bezahlen nichts.");
            }

            else
            {
                if (alter < 19)
                {
                    Console.WriteLine("Sie bezahlen 5,50 Euro.");
                }

                else
                {
                    if (alter > 18)
                    {
                        Console.WriteLine("Sie bezahlen 10 Euro.");
                    }
                    else
                    {
                        Console.WriteLine("Fehler");
                    }
                }
            }
        }
        static void Rechteck()
        {
            //Definition von Variablen
            double zahl_laenge, zahl_breite;
            double zahl_umfang, zahl_flaeche;

            //Einführung
            Console.WriteLine("Mit diesem Programm kann der Umfang und die Fläche eines Rechtecks berechnet werden");

            //Absatz1
            Console.WriteLine("");

            //Einlesen der Zahlen
            Console.Write("Geben Sie die Länge ein:  ");
            zahl_laenge = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geben sie die Breite ein:  ");
            zahl_breite = Convert.ToDouble(Console.ReadLine());

            //Berechnung
            zahl_umfang = zahl_laenge * 2 + zahl_breite * 2;
            zahl_flaeche = zahl_laenge * zahl_breite;

            //Ausgabe am Bildschirm
            Console.WriteLine("Der Umfang beträgt:  " + zahl_umfang);
            Console.WriteLine("Die Fläche beträgt:  " + zahl_flaeche);
        }
        static void Zahl1_gleich_Zahl2()
        {
            //Variablen festlegen
            int a1;

            //Eingabe erste Zahl
            Console.Write("Bitte die erste Zahl eingeben: ");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a1: {0}", a1);

            //Eingebe der zweiten Zahl
            int a2;
            Console.Write("Bitte die zweite Zahl eingeben: ");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a2: {0}", a2);

            //Ausgabe (Gleiche  Zahl)
            if (a1 == a2)
            {
                Console.WriteLine("Die Zahlen sind gleich groß.");
            }

            //Ausgabe (a1 ist größer)
            else
            {
                if (a1 > a2)
                {
                    Console.WriteLine("Die Zahl a1 ist größer");
                }
                if (a2 > a1)
                {
                    Console.WriteLine("Die Zahl a2 ist größer");
                }
            }
        }
        static void Zylinder()
        {
            //Defienierung der Variable
            double radius, hoehe, oberflaeche, volumen;

            //Radius eingeben
            Console.Write("Geben Sie bitte den Radius ein:  ");
            radius = Convert.ToSingle(Console.ReadLine());

            //Höhe Eingeben
            Console.Write("Geben Sie bitte die Höhe ein:  ");
            hoehe = Convert.ToSingle(Console.ReadLine());

            //Berechnung
            oberflaeche = 2 * Math.PI * radius * radius + 2 * Math.PI * radius * hoehe;
            volumen = Math.PI * radius * radius * hoehe;

            //Leere Zeile
            Console.WriteLine();

            //Ausgabe vom Ergebnis
            Console.WriteLine("Die Oberfläche beträgt: {0:F2}", oberflaeche);
            Console.WriteLine("Das Volumen beträgt: {0:F2}", volumen);
        }
        static void For_Schleife_Aufgabe_a()
        {
            //Deklarierung der Variablen
            double zahl, hochzahl, summe;

            //Berechnung und Ausgabe
            summe = 0;

            for (zahl = 1; zahl < 101; zahl++)
            {
                hochzahl = Math.Pow(zahl, 2);
                summe = summe + hochzahl;
            }

            Console.WriteLine(summe);
        }
        static void For_Schleife_Aufgabe_b()
        {
            //Deklarierung der Variable
            int zahl, fakultaet;

            //Erklärung des Programms
            Console.WriteLine("Dieses Programm kann die Fakultät einer ganzen Zahl berechnen.");

            //Einlesen der Zahl
            Console.Write("Geben Sie eine ganze Zahl ein:  ");
            zahl = Convert.ToInt32(Console.ReadLine());

            //Berechnung
            fakultaet = 1;

            for (int zaehler = 1; zaehler <= zahl; zaehler++)
            {
                fakultaet = fakultaet * zaehler;
            }

            //Ausgeben der Summe
            Console.WriteLine("Die Fakultät aus {0} beträgt {1}.", zahl, fakultaet);
        }
        static void While_Schleife()
        {
            //Aufgabe a
            //Deklarierung der Variablen
            int zahl = 1;
            double summe = 0;

            //Was das Programm kann
            Console.WriteLine("Dieses Programm summiert die ersten 100 Quadratzahlen auf.");

            //Berechnung
            while (zahl <= 100)
            {
                summe = summe + Math.Pow(zahl, 2);
                zahl++;
            }

            //Ergebnis Ausgeben
            Console.WriteLine("Das Ergebnis beträgt {0}", summe);



            //Leere Zeile
            Console.WriteLine(" ");



            //Aufgabe b
            //Deklarierung der Variable und Überschreibung
            summe = 1;
            zahl = 1;
            double eingabefakultaet;

            //Eingabe der Fakultät
            Console.Write("Geben Sie bitte die Zahl ein aus der die Fakultät berechnet werden soll: ");
            eingabefakultaet = Convert.ToDouble(Console.ReadLine());

            //Berechnung
            while (zahl <= eingabefakultaet)
            {
                summe = summe * zahl;
                zahl++;
            }

            //Ergebnis ausgeben
            Console.WriteLine("Die Fakultät beträgt: {0}", summe);



            Console.WriteLine(" ");



            //Aufgabe c
            //Deklarierung der Variable und Überschreibung
            int anzahlprodukte = 0;
            zahl = 1;
            summe = 0;

            //Eingabe der unterschiedlichen Produkte
            Console.Write("Wie viele unterschiedliche Produkte: ");
            anzahlprodukte = Convert.ToInt32(Console.ReadLine());

            //Berechnung
            while (zahl <= anzahlprodukte)
            {
                //Wieviele davon
                Console.Write("Wieviele von diesem Produkt gibt es: ");
                double anzahlprodukt = Convert.ToDouble(Console.ReadLine());

                //Wie viel ist eines Wert
                Console.Write("Wieviel Wert: ");
                double anzahlwert = Convert.ToDouble(Console.ReadLine());

                summe = (anzahlprodukt * anzahlwert) + summe;
                zahl++;
            }

            //Ergebnis ausgeben
            Console.WriteLine("Die Summe beträgt: {0}", summe);



            //Leere Zeile
            Console.WriteLine(" ");



            //Aufgabe 2c)
            //Deklarirung der Variablen und Überschreibung
            zahl = 1;
            summe = 1;
            double basis;
            double hochzahl;

            //Eingabe der Zahlen
            Console.Write("Geben Sie bitte die Basis ein: ");
            basis = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geben Sie die Hochzahl ein: ");
            hochzahl = Convert.ToDouble(Console.ReadLine());

            //Berechnung
            while (zahl <= hochzahl)
            {
                summe = summe * basis;
                zahl++;
            }

            //Ergebnis ausgeben
            Console.WriteLine("Das Ergebnis beträgt: {0}", summe);
        }
        static void Do_While_Schleife()
        {
            //Deklarierung der Variablen
            int summe = 1;
            int counter = 0;

            //Aufgabe: Welches ist besser?
            //Berechnung
            do
            {
                summe *= 2;
                counter++;
            }
            while (counter < 20);

            //Ausgabe
            if (summe > 2000000)
            {
                Console.WriteLine("Die 21 Tage sind besser.");
            }
            else
            {
                Console.WriteLine("Die 20 000 Euro sind besser.");
            }

            //Aufgabe: Wie lange braucht man um 100 000 Euro zu erreichen?
            summe = 1;
            counter = 1;

            do
            {
                summe *= 2;
                counter++;
            }
            while (summe < 10000000);

            //Ausgabe
            Console.WriteLine("Man benötigt " + counter + " Tage.");
        }
        static void String_Aufgabe()
        {
            //Aufgabe 1: Programm welche Vorname und Nachname zusammenfügt
            //Eingabe des Vornamens
            Console.Write("Bitte geben Sie den Vorname ein: ");
            string vorname = Convert.ToString(Console.ReadLine());

            //Eingabe des Nachnamens
            Console.Write("Bitte geben Sie den Nachname ein: ");
            string nachname = Convert.ToString(Console.ReadLine());

            //Ausgabe des Ergebnises
            Console.WriteLine("Der Name lautet " + vorname + " " + nachname + ".\n");



            //Aufgabe 2: Schreiben eines Programms welches die Anzahl der Buchtstaben in einem Satz ausgibt
            //Eingabe des Satzes
            Console.Write("Geben Sie bitte den Satz ein: ");
            string satz = Convert.ToString(Console.ReadLine());

            //Eingabe des gesuchten Buchstaben
            Console.Write("Gib den gesuchten Buchstaben ein: ");
            char buchstabe = Convert.ToChar(Console.ReadLine());

            //Mit einer for-Schleife jeden Buchstaben durchgehen und Vergleichen
            int ergebnis = 0;
            for (int zaehler = 0; zaehler < satz.Length; zaehler++)
            {
                if (satz[zaehler] == buchstabe)
                {
                    ergebnis++;
                }
            }

            //Ergebnis ausgeben
            Console.WriteLine("Das Ergebnis beträgt: {0}\n", ergebnis);



            //Aufgabe 3: Die Ziffernsumme berechnen
            //Eingabe der Zahl
            Console.Write("Geben Sie bitte die Zahl ein: ");
            string zahl = Convert.ToString(Console.ReadLine());

            //Kontrollieren ob diese Zahl größer als 8 ist
            if (zahl.Length > 8)
            {
                Console.WriteLine("Diese Zahl überschreitet die maximale Größe.");
            }
            else
            {
                //Berechung der Ziffernsumme mittels der for-Schleife
                ergebnis = 0;
                for (int zaehler = 0; zaehler < zahl.Length; zaehler++)
                {
                    ergebnis += Int32.Parse(zahl[zaehler].ToString());
                }

                //Ausgabe des Ergebnisses
                Console.WriteLine("Das Ergebnis beträgt: {0}", ergebnis);
            }
        }
        static void String_Aufgabe_2()
        {
            //Aufgabe 1: Schreiben Sie ein Programm, welches einen Text einlies und danach verkehrt ausgibt
            //Eingabe des Textes
            Console.Write("Geben Sie bitte den Text: ");
            string text = Convert.ToString(Console.ReadLine());

            //Umkehren des Textes
            string ergebnis = "";
            for (int zaehler = 0; zaehler < text.Length; zaehler++)
            {
                ergebnis += text[text.Length - 1 - zaehler].ToString();
            }

            //Ausgabe des Ergebnisses
            Console.WriteLine("Der Text umgekehrt ist: {0}\n", ergebnis);



            //Aufgabe 2: Lesen Sie einen Satz ein und geben Sie danach aus, wie oft das Wort "ist" vorkommt
            //Eingabe des Satzes
            Console.Write("Geben Sie einen Satz ein: ");
            string satz = Convert.ToString(Console.ReadLine());

            //Zählen wie oft ist vorkommt
            int ergebnis2 = 0;
            for (int zaehler2 = 0; zaehler2 < satz.Length - 2; zaehler2++)
            {
                if (satz.Substring(zaehler2, 3) == "ist")
                {
                    ergebnis2++;
                }
            }

            //Ausgabe des Ergebnisses
            Console.WriteLine("Im Satz kommen {0} Mal ist vor.\n", ergebnis2);



            //Aufgabe 3: In einem Satz ist "Maier" falsch geschrieben und sollte durch "Meyer" ersetzt werden
            //Eingabe des Satzes
            Console.Write("Geben Sie bitte den Satz ein: ");
            string satz2 = Convert.ToString(Console.ReadLine());

            //Maier ersetzen
            string ergebnis3 = "";
            for (int zaehler3 = 0; zaehler3 < satz2.Length - 4; zaehler3++)
            {
                if (satz2.Substring(zaehler3, 5) == "Maier")
                {
                    ergebnis3 = satz2.Remove(zaehler3, 5);
                    ergebnis3 = ergebnis3.Insert(zaehler3, "Meyer");
                }
            }

            //Ausgabe des Ergebnisses
            Console.WriteLine("Das Ergebnis ist: {0}\n", ergebnis3);



            //Aufgabe 4: Lesen Sie drei Namen ein und geben Sie dem im Alphabet vorne liegenden aus.
            //Einlesen von drei Namen
            //Name 1
            Console.Write("Geben Sie den ersten Namen ein: ");
            string name1 = Convert.ToString(Console.ReadLine());

            //Name 2
            Console.Write("Geben Sie den ersten Namen ein: ");
            string name2 = Convert.ToString(Console.ReadLine());

            //Name 3
            Console.Write("Geben Sie den ersten Namen ein: ");
            string name3 = Convert.ToString(Console.ReadLine());

            //Vergleichen der Namen und Ausgabe
            if (String.Compare(name1, name2) == 1)
            {
                if (String.Compare(name2, name3) == 1)
                {
                    Console.WriteLine(name3 + " liegt im Alphabet vorne.");
                }
                else
                {
                    Console.WriteLine(name2 + " liegt im Alphabet vorne.");
                }
            }
            else
            {
                if (String.Compare(name1, name3) == 1)
                {
                    Console.WriteLine(name3 + " liegt im Alphabet vorne.");
                }
                else
                {
                    Console.WriteLine(name1 + " liegt im Alphabet vorne.");
                }
            }
        }
        static void Array()
        {
            //Namen in ein Array speichern
            //Array Variable erstellen
            string[] schuelernamen = new String[5];

            //Mit einer for-Schleife durchgehen bis alle Aufgaben ausgeführt wurden
            //Variable für Aufgabe 2
            int minus = 0;

            //Variable für Aufgabe 3
            string gesuchter_name = "";

            //Beginn der for-Schleife
            for (int zaehler = 0; zaehler < 22; zaehler++)
            {
                //Solang der Zaehler kleiner als 5 ist werden die Namen eingelesen
                if (zaehler < 5)
                {
                    //Eingabe der Namen
                    Console.Write("Geben Sie bitte den {0}.Namen ein: ", zaehler + 1);
                    schuelernamen[zaehler] = Convert.ToString(Console.ReadLine());
                }

                //Leere Zeile
                if (zaehler == 4) { Console.WriteLine(" "); }

                //Aufgabe 1: Schülernamen der Reihenfolge nach ausgeben
                //Solang der zaehler in dem if-Bereich liegt wird die erste Aufgabe ausgeführt
                if (zaehler > 5 && zaehler < 11)
                {
                    //Ausgabe
                    Console.WriteLine((zaehler - 5) + "." + schuelernamen[zaehler - 6]);
                }

                //Leere Zeile
                if (zaehler == 10) { Console.WriteLine(" "); }

                //Aufgabe 2: Schülernamen umgekehrt ausgeben
                if (zaehler > 11 && 17 > zaehler)
                {
                    //Ausgabe
                    Console.WriteLine((zaehler - 11) + "." + schuelernamen[zaehler - 8 - minus]);

                    //Variable +2 rechnen um im nächsten Durchgang den nächst niedriegeren Array String auszugeben
                    minus += 2;
                }

                //Leere Zeile
                if (zaehler == 16) { Console.WriteLine(" "); }

                //Aufgabe 3: Einen Namen eingeben und dazu soll die dazugehörige Katalognummer gefunden werden
                //Eingabe des gesuchten Wertes bevor die letzte if-Bedingung ausgeführt wird
                if (zaehler == 16)
                {
                    //Eingabe des Namens
                    Console.Write("Geben Sie den gesuchten Namen ein: ");
                    gesuchter_name = Convert.ToString(Console.ReadLine());
                }

                //Wird durchgegangen wo sich der gesuchte Name befindet
                if (zaehler > 16)
                {
                    //Schauen in welchen Array Ort er sich befindet
                    if (gesuchter_name == schuelernamen[zaehler - 17])
                    {
                        Console.WriteLine("Die Katalognummer für diesen Schüler lautet {0}.", zaehler - 17 + 1);
                    }
                }
            }
        }
        static void Array_Extra()
        {
            //Variable deklarieren
            int[] Zahlen = new int[10];

            //Ausgabe und Ergebniswerte für alle 5 Aufgabe
            int groesste_zahl = 0;
            int kleinste_zahl = 0;
            int summe_aller_zahlen = 0;
            string alle_geraden_zahlen = "";
            string alle_zahlen_groesser_als_mittelwert = "";
            string ausgabe = "\n";

            //Eingabe und Berechnung der Aufgaben außer die Summe
            for (int zaehler1 = 0; zaehler1 < Zahlen.Length; zaehler1++)
            {
                //Eingabe
                Console.Write((zaehler1 + 1) + ".Zahl eingaben: ");
                Zahlen[zaehler1] = Convert.ToInt32(Console.ReadLine());

                //Speichern der Ausgabe in String
                ausgabe += (zaehler1 + 1) + ".Zahl: " + Zahlen[zaehler1] + "\n";

                //größte Zahl
                //Einen Anfangswert speichern um bei Minuszahlen Probleme zu vermeiden
                if (zaehler1 == 0) { groesste_zahl = Zahlen[zaehler1]; }

                //Checken wenn der Wert größer ist
                if (groesste_zahl <= Zahlen[zaehler1]) { groesste_zahl = Zahlen[zaehler1]; }

                //kleinste Zahl
                //Einen Anfangswert speichern um bei Minuszahlen Probleme zu vermeiden
                if (zaehler1 == 0) { kleinste_zahl = Zahlen[zaehler1]; }

                //Checken ob der Wert kleiner ist
                if (kleinste_zahl >= Zahlen[zaehler1]) { kleinste_zahl = Zahlen[zaehler1]; }

                //Summe berechnen
                summe_aller_zahlen += Zahlen[zaehler1];

                //alle geraden Zahlen in ein String speichern
                if (Zahlen[zaehler1] % 2 == 0) { alle_geraden_zahlen += Convert.ToString(Zahlen[zaehler1]) + ", "; }
            }

            //Extra for-Schleife wegen dem größer als Mittelwert
            for (int zaehler_mittelwert = 0; zaehler_mittelwert < Zahlen.Length; zaehler_mittelwert++) { if (summe_aller_zahlen / Zahlen.Length < Zahlen[zaehler_mittelwert]) { alle_zahlen_groesser_als_mittelwert += Convert.ToString(Zahlen[zaehler_mittelwert]) + ", "; } }

            //Ausgabe von allem
            Console.WriteLine(ausgabe + "\n" + "Die größte Zahl: " + groesste_zahl + "\n" + "Die kleinste Zahl: " + kleinste_zahl + "\n" + "Die Summe aller Zahlen: " + summe_aller_zahlen + "\n" + "Alle geraden Zahlen: " + alle_geraden_zahlen + "\n" + "Alle Zahlen größer als der Mittelwert: " + alle_zahlen_groesser_als_mittelwert);

            //Das die Console offen bleibt
            Console.ReadLine();
        }
        static void durschnittliche_Abkuehlung()
        {
            //Public minuten
            int minuten = 101;

            //Ergebnis welches zum Ausgeben ist
            string ergebnis = "";

            //Formatierung hinzufügen (Absätze sind klar mit + getrennt)
            ergebnis += "Diese Programm erzeugt eine Tabelle und zusätzliche Informationen über drei Formeln.\n\n" + "+-------------------------------------------------------------------------------+ \n" + "| Zeit\t|\tFormel-a)\t\tFormel-b)\t\tFormel-c)\t|\n" + "+-------------------------------------------------------------------------------+\n" + "| 0\t|\t100.00\t\t\t100.00\t\t\t100\t\t|\n";

            //Bei Double a = 1 und b = 2
            //Arrays zum Speichern der Tabellenwerte und zusätzliche Werte (erste 101 Slots für Formelberechnung, der 102.Slot jeweils für die Summe aller Zahlen, den Mittelwert im vorletzten Slot und letzten Slot für die lineare die es haben sollte)
            double[] zahlen_a = new Double[104];
            double[] zahlen_b = new Double[104];
            int[] zahlen_c = new Int32[104];

            //Bool zum Angeben ob es linear ist (erster Slot a, zweiter b und dritter c)
            bool[] linear = new bool[3];

            //Berechnung der Tabelle mit den Formeln
            for (int zaehler = 0; zaehler < minuten; zaehler++)
            {
                //Formeln berechnen und in die Slots speichern
                zahlen_a[zaehler] = 100 - (Convert.ToDouble(zaehler) / 4.0) * Math.Pow(Math.E, 1 / (3 * Convert.ToDouble(zaehler) + 1));
                zahlen_b[zaehler] = 100 - (zaehler / 4.0);
                zahlen_c[zaehler] = 100 - zaehler;

                //Welche lineare es haben sollte
                if (zaehler == 1)
                {
                    zahlen_a[103] = zahlen_a[0] - zahlen_a[1];
                    zahlen_b[103] = zahlen_b[0] - zahlen_b[1];
                    zahlen_c[103] = zahlen_c[0] - zahlen_c[1];
                }

                //Linear oder nicht
                if (zaehler > 0)
                {
                    //Checkt alle durch ob Sie gleich (linear verlaufen)
                    if (zahlen_a[zaehler - 1] - zahlen_a[zaehler] == zahlen_a[103]) { linear[0] = true; } else { linear[0] = false; }
                    if (zahlen_b[zaehler - 1] - zahlen_b[zaehler] == zahlen_b[103]) { linear[1] = true; } else { linear[1] = false; }
                    if (zahlen_c[zaehler - 1] - zahlen_c[zaehler] == zahlen_c[103]) { linear[2] = true; } else { linear[2] = false; }
                }

                //Summe aller Zahlen
                zahlen_a[101] += zahlen_a[zaehler];
                zahlen_b[101] += zahlen_b[zaehler];
                zahlen_c[101] += zahlen_c[zaehler];

                //Damit der Anfangswert nicht angefügt wird
                if (zaehler > 0)
                {
                    //Alle Ausgabe Werte in den Ergebnis String speichern
                    ergebnis += "| " + Convert.ToString(zaehler) + "\t|\t" + Convert.ToString(Math.Round(zahlen_a[zaehler], 2) + "\t\t\t" + Convert.ToString(Math.Round(zahlen_b[zaehler], 2)) + "\t\t\t" + Convert.ToString(zahlen_c[zaehler]) + "\t\t|\n");
                }
            }

            //Ende der Tabelle anfügen
            ergebnis += "+-------------------------------------------------------------------------------+\n";

            //Mittelwert
            zahlen_a[102] = zahlen_a[101] / 101;
            zahlen_b[102] = zahlen_b[101] / 101;
            zahlen_c[102] = zahlen_c[101] / 101;

            //Anfügen der zusätzlichen Werte
            ergebnis += "| Zusätzliche Informationen:\t\t\t\t\t\t\t|\n" + "| Mittelwert:\t" + Math.Round(zahlen_a[102], 2) + "\t\t\t" + Math.Round(zahlen_b[102], 2) + "\t\t\t" + zahlen_c[102] + "\t\t|\n" + "| Linear:\t" + Convert.ToString(linear[0]) + "\t\t\t" + Convert.ToString(linear[1]) + "\t\t\t" + Convert.ToString(linear[2]) + "\t\t|\n" + "+ -------------------------------------------------------------------------------+\n" + " \n" + "+-------------------------------------------------------------------------------+\n" + "| Mittelwert zu jedem Zeitpunkt:\t\t\t\t\t\t|\n" + "+-------------------------------------------------------------------------------+\n" + "| 0\t|\t100.00\t\t\t100.00\t\t\t100\t\t|\n";

            //Mittelwert zu jedem Zeitpunkt
            zahlen_a[101] = 0;
            zahlen_b[101] = 0;
            zahlen_c[101] = 0;
            for (int zaehler2 = 0; zaehler2 < 101; zaehler2++)
            {
                double divisionswert = Convert.ToDouble(zaehler2) + 1;

                zahlen_a[101] += zahlen_a[zaehler2];
                double mittelwert_a_jederzeitpunkt = zahlen_a[101] / divisionswert;

                zahlen_b[101] += zahlen_b[zaehler2];
                double mittelwert_b_jederzeitpunkt = zahlen_b[101] / divisionswert;

                zahlen_c[101] += zahlen_c[zaehler2];
                int mittelwert_c_jederzeitpunkt = zahlen_c[101] / Convert.ToInt32(divisionswert);


                if (zaehler2 > 0)
                {
                    ergebnis += "| " + zaehler2 + "\t|\t" + Math.Round(mittelwert_a_jederzeitpunkt, 2) + "\t\t\t" + Math.Round(mittelwert_b_jederzeitpunkt, 2) + "\t\t\t" + mittelwert_c_jederzeitpunkt + "\t\t|\n";
                }
            }

            //Tabellenende
            ergebnis += "+-------------------------------------------------------------------------------+";

            //Das Endprodukt ausgeben
            Console.WriteLine(ergebnis);

            //Damit die Console offen bleibt
            Console.ReadLine();
        }
    }
}
