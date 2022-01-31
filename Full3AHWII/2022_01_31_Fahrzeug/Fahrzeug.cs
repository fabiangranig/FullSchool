//Fabian Granig 3AHWII
//31.01.2022
//Beispiel: Fahrzeug
using System;

namespace _20220131_Fahrzeug
{
    class Fahrzeug
    {
        //Attribute der Klasse
        string name;
        int reifenanzahl;
        double geschwindigkeit;
        double tankinhalt;
        double km_stand;
        string treibstoffart;

        //Standartkonstruktor
        public Fahrzeug()
        {
            this.name = "";
            this.reifenanzahl = 4;
            this.geschwindigkeit = 0;
            this.tankinhalt = 0;
            this.km_stand = 0;
            this.treibstoffart = "";
        }

        //normaler Konstruktor
        public Fahrzeug(string name1, int reifen, string treibstoff)
        {
            this.name = name1;
            this.reifenanzahl = reifen;
            this.treibstoffart = treibstoff;
            this.geschwindigkeit = 60;
            this.tankinhalt = 50;
        }

        //Methode zum Anzeigen von allen Daten
        public void Anzeigen()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Reifenanzahl: " + this.reifenanzahl);
            Console.WriteLine("Geschwindigkeit: " + this.geschwindigkeit);
            Console.WriteLine("Tankinhalt: " + this.tankinhalt);
            Console.WriteLine("Km Stand: " + this.km_stand);
            Console.WriteLine("Treibstoffart: " + this.treibstoffart);
        }

        //Methode zum Tanken des Fahrzeugs
        public void Tanken()
        {
            //Den Tankinhalt auf den vollen Wert setzen
            this.tankinhalt = 50;
        }

        //Methode zum Fahren des Fahrzeugs
        public void Fahren(double dauer, double geschwindigkeit1)
        {
            //die neue Geschwindigkeit setzen
            if(geschwindigkeit1 == 0)
            {

            }
            else
            {
                this.geschwindigkeit = geschwindigkeit1;
            }

            //Errechnen wie viele Kilometer gefahren werden
            double kilometer = this.geschwindigkeit * dauer;

            //Kontrollieren ob es ein Diesel- oder ein Benzinfahrzeug ist
            double liter_auf_hundert_kilometer = 0;
            if(this.treibstoffart.Contains("Diesel"))
            {
                liter_auf_hundert_kilometer = 5;
            }
            if (this.treibstoffart.Contains("Benzin"))
            {
                liter_auf_hundert_kilometer = 7;
            }

            //Nun berechnen wie viele Liter es verbraucht
            double verbrauch_pro_kilometer = liter_auf_hundert_kilometer / 100;

            //Berechnen wie viel Liter man für diese Fahrt benötigt
            double fahrt_verbrauch = kilometer * verbrauch_pro_kilometer;

            //Wenn genug Sprit verfügbar ist, wird gefahren sonst nicht
            if(fahrt_verbrauch < this.tankinhalt)
            {
                Console.WriteLine("Strecke wurde gefahren.");

                //Die Kilometer am Kilometerstand vermerken
                this.km_stand += kilometer;

                //Verbrauch auf Tank vermerken
                this.tankinhalt -= fahrt_verbrauch;
            }
            else
            {
                Console.WriteLine("Tankinhalt zu niedrieg.");
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //Eingabe
            Console.Write("Geben Sie bitte den Namen des Autos ein: ");
            string fahrzeug_name = Convert.ToString(Console.ReadLine());
            Console.Write("Geben Sie die Reifenanzahl ihres Autos ein: ");
            int fahrzeug_reifenanzahl = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geben Sie die Treibstoffart ihres Autos ein: ");
            string fahrzeug_treibstoffart = Convert.ToString(Console.ReadLine());

            //Erstellen eines Fahrzeug
            Fahrzeug f1 = new Fahrzeug(fahrzeug_name, fahrzeug_reifenanzahl, fahrzeug_treibstoffart);

            //leere Zeile
            Console.WriteLine();

            //Anzeigen der aktuellen Werte des Fahrzeug
            Console.WriteLine("Die Werte des Autos f1, werden angezeigt: ");
            f1.Anzeigen();

            //leere Zeile
            Console.WriteLine();

            //Eingabe wie lange und wie weit das Auto fahren soll
            Console.Write("Wie schnell soll das Auto fahren? ");
            double fahrzeug_geschwindigkeit = Convert.ToDouble(Console.ReadLine());
            Console.Write("Wie lange soll das Auto fahren (in Stunden)? ");
            double fahrzeug_fahrdauer = Convert.ToDouble(Console.ReadLine());

            //leere Zeile
            Console.WriteLine("");

            //Mit dem Auto fahren
            f1.Fahren(fahrzeug_fahrdauer, fahrzeug_geschwindigkeit);

            //leere Zeile
            Console.WriteLine("");

            //Die Werte sollen erneut angezeigt werden
            f1.Anzeigen();

            //leere Zeile
            Console.WriteLine("");

            //Der Tank wird aufgefüllt
            Console.WriteLine("Das Auto wird getankt.");
            f1.Tanken();

            //leere Zeile
            Console.WriteLine("");

            //Die Werte werden wieder angezeigt
            f1.Anzeigen();
        }
    }
}
