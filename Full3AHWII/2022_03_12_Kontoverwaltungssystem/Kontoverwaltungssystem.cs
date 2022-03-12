using System;

namespace Template_Datei
{
		//Klasse Konto
		class Konto
		{		
				//Erstellen von Variablen
				private int kontonummer;
				private double kontostand;
				private int anzahl_buchungen;

				//Kapselung
				public Kontonummer
				{
						get { return kontonummer; }
				}
				public Kontostand
				{
						get { return kontostand; }
						set { kontostand = Kontostand; }
				}
				public Anzahl_buchungen
				{
						get { return anzahl_buchungen; }
						set { anzahl_buchungen = Anzahl_buchungen; }
				}

				//Konstruktor
				public Konto(int kontonummer1)
				{
						this.kontonummer = kontonummer1;
						this.kontostand = 0;
						this.anzahlbuchungen = 0;
				}
				public Konto(int kontonummer1, double kontostand1, int anzahl_buchungen1)
				{
						this.kontonummer = kontonummer1;
						this.kontostand = kontostand1;
						this.anzahlbuchungen = anzahl_buchungen1;
				}
		}

		class Program
    {
        static void Main(string[] args)
        {
						//Erstellen von zwei Konton
						Konto konto1 = new Konto(5432);
						Konto konto2 = new Konto(2345, 100, 1);
        }
    }
}
