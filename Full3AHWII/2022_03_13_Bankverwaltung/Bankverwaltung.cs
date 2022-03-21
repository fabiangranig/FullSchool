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
		public int Kontonummer
		{
			get { return kontonummer; }
		}
		public double Kontostand
		{
			get { return kontostand; }
		}
		public int Anzahl_buchungen
		{
			get { return anzahl_buchungen; }
		}

		//Konstruktor
		public Konto(int kontonummer1)
		{
			this.kontonummer = kontonummer1;
			this.kontostand = 0;
			this.anzahl_buchungen = 0;
		}
		public Konto(int kontonummer1, double kontostand1, int anzahl_buchungen1)
		{
			this.kontonummer = kontonummer1;
			this.kontostand = kontostand1;
			this.anzahl_buchungen = anzahl_buchungen1;
		}

		//Methoden
		public void Auf_Ab_Buchen(double betrag)
		{
			this.kontostand += betrag;
			this.anzahl_buchungen++;
		}
		public void Anzeigen()
		{
			Console.WriteLine("Die Kontonummer ist: " + this.kontonummer);
			Console.WriteLine("Der Kontostand beträgt: " + this.kontostand);
			Console.WriteLine("Die Anzahl der Buchungen beträgt: " + this.anzahl_buchungen);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			//Erstellen von zwei Konton
			Konto konto1 = new Konto(5432);
			Konto konto2 = new Konto(2345, 100, 1);

			//Beide Konten anzeigen
			Console.WriteLine("Konto1 wird angezeigt: ");
			konto1.Anzeigen();
			Console.WriteLine("");
			Console.WriteLine("Konto2 wird angezeigt: ");
			konto2.Anzeigen();

			//leere Zeile
			Console.WriteLine("----------------------------------------------");

			//Bei beiden Konten was ab und auf buchen
			konto1.Auf_Ab_Buchen(300);
			konto2.Auf_Ab_Buchen(-50);

			//Beide Konten anzeigen
			Console.WriteLine("Konto1 wird angezeigt: ");
			konto1.Anzeigen();
			Console.WriteLine("");
			Console.WriteLine("Konto2 wird angezeigt: ");
			konto2.Anzeigen();
		}
	}
}