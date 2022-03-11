using System;

namespace _20220309_Boot
{
    //Klasse Boot
    class Boot
    {
        //Attribute
        private string name;
        private double laenge;
        private double breite;
        private double geschwindigkeit;
        private double hoechstgeschwindigkeit;
        private int anzahlInsassen;
        private int maximaleInsassen;
        private double tatsaechlichesGewicht;
        private double zulGesamtgewicht;
        private double eigengewicht;

        //Schreibschutz
        public string Name
        {
            get { return name; }
            set { name = Name; }
        }
        public double Laenge
        {
            get { return laenge; }
        }
        public double Breite
        {
            get { return breite; }
        }
        public double Geschwindigkeit
        {
            get { return geschwindigkeit; }
            set { geschwindigkeit = Geschwindigkeit; }
        }
        public double Hoechstgeschwindigkeit
        {
            get { return hoechstgeschwindigkeit; }
        }
        public int AnzahlInsassen
        {
            get { return anzahlInsassen; }
            set { anzahlInsassen = AnzahlInsassen; }
        }
        public int MaximaleInsassen
        {
            get { return maximaleInsassen; }
        }
        public double TatsaechlichesGewicht
        {
            get { return tatsaechlichesGewicht; }
            set { tatsaechlichesGewicht = TatsaechlichesGewicht; }
        }
        public double ZulGesamtgewicht
        {
            get { return zulGesamtgewicht; }
        }
        public double Eigengewicht
        {
            get { return eigengewicht; }
            set { eigengewicht = Eigengewicht; }
        }

        //Konstruktor
        //Default Konstruktor
        public Boot()
        {
            this.name = "";
            this.laenge = 0;
            this.breite = 0;
            this.geschwindigkeit = 0;
            this.hoechstgeschwindigkeit = 0;
            this.anzahlInsassen = 0;
            this.maximaleInsassen = 0;
            this.tatsaechlichesGewicht = 0;
            this.zulGesamtgewicht = 0;
            this.eigengewicht = 0;
        }

        //Festgelegter Konstruktor
        public Boot(string name1, double laenge1, double breite1, double hoechstgeschwindigkeit1, int anzahlInsassen1, int maximaleInsassen1, double zulGesamtgewicht1, double eigengewicht1)
        {
            this.name = name1;
            this.laenge = laenge1;
            this.breite = breite1;
            this.geschwindigkeit = 5;
            this.hoechstgeschwindigkeit = hoechstgeschwindigkeit1;
            this.anzahlInsassen = anzahlInsassen1;
            this.maximaleInsassen = maximaleInsassen1;
            this.tatsaechlichesGewicht = anzahlInsassen1 * 70 + eigengewicht1;
            this.zulGesamtgewicht = zulGesamtgewicht1;
            this.eigengewicht = eigengewicht1;

            //Checken ob Gewicht passt
            if(zulGesamtgewicht < tatsaechlichesGewicht)
            {
                this.zulGesamtgewicht = tatsaechlichesGewicht;
            }
        }

        //Methode Anzeigen
        public void Anzeigen()
        {
            //Ausgabe
            Console.WriteLine("Werte des Bootes: ");
            Console.WriteLine("Name des Bootes: " + this.name);
            Console.WriteLine("Länge des Bootes: " + this.laenge);
            Console.WriteLine("Breite des Bootes: " + this.breite);
            Console.WriteLine("Geschwindigkeit des Bootes: " + this.geschwindigkeit);
            Console.WriteLine("Höchstgeschwindigkeit des Bootes: " + this.hoechstgeschwindigkeit);
            Console.WriteLine("Anzahl der Insassen des Bootes: " + this.anzahlInsassen);
            Console.WriteLine("maximale Anzahl der Insassen: " + this.maximaleInsassen);
            Console.WriteLine("tatsächliche Gewicht des Bootes: " + this.tatsaechlichesGewicht);
            Console.WriteLine("zugelassenes Gewicht des Bootes: " + this.zulGesamtgewicht);
            Console.WriteLine("Eigengewicht des Bootes: " + this.eigengewicht);
        }

        //Methode Zu_oder_Absteigen
        public void Zu_oder_Absteigen(int neue_Insassen)
        {
            if(this.geschwindigkeit == 0)
            {
                if(this.anzahlInsassen + neue_Insassen <= this.maximaleInsassen && anzahlInsassen + neue_Insassen >= 0)
                {
                    this.anzahlInsassen += neue_Insassen;
                }
            }
        }

        //Methode Geschwindigkeit_setzen
        public void Geschwindigkeit_setzen(double geschwindigkeit)
        {
            if(geschwindigkeit >= 0 && this.hoechstgeschwindigkeit >= geschwindigkeit)
            {
                this.geschwindigkeit = geschwindigkeit;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Eingabe der Werte
            Console.Write("Boot Name: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.Write("Boot Länge: ");
            double laenge = Convert.ToDouble(Console.ReadLine());
            Console.Write("Boot Breite: ");
            double breite = Convert.ToDouble(Console.ReadLine());
            Console.Write("Boot Hoechstgeschwindigkeit: ");
            double hoechstgeschwindigkeit = Convert.ToDouble(Console.ReadLine());
            Console.Write("Anzahl der Insassen: ");
            int anzahlinsassen = Convert.ToInt32(Console.ReadLine());
            Console.Write("maximale Anzahl der Insassen: ");
            int maximaleinsassen = Convert.ToInt32(Console.ReadLine());
            Console.Write("zulgelassenes Gesamtgewicht: ");
            double zulgewicht = Convert.ToDouble(Console.ReadLine());
            Console.Write("Eigengewicht: ");
            double eigengewicht = Convert.ToDouble(Console.ReadLine());

            //das Boot erstellen
            Boot boot1 = new Boot(name, laenge, breite, hoechstgeschwindigkeit, anzahlinsassen, maximaleinsassen, zulgewicht, eigengewicht);

            //leeres Zeile
            Console.WriteLine("");

            //Anzeigen der Informationen
            boot1.Anzeigen();

            //leere Zeile
            Console.WriteLine("");

            //Testen ob man einsteigen kann während das Boot fährt
            Console.WriteLine("Testen ob man aussteigen kann wenn man fährt.");
            boot1.Zu_oder_Absteigen(-2);

            //leere Zeile
            Console.WriteLine("");

            //Nochmaliges Anzeigen
            boot1.Anzeigen();

            //leere Zeile
            Console.WriteLine("");

            //Boot stoppen
            Console.WriteLine("Das Boot wird gestoppt.");
            Console.WriteLine("Nun sollen 5 Gäste einsteigen und 3 aussteigen.");
            boot1.Geschwindigkeit_setzen(0);
            boot1.Zu_oder_Absteigen(5);
            boot1.Zu_oder_Absteigen(-3);

            //leere Zeile
            Console.WriteLine("");

            //Nochmaliges Anzeigen
            boot1.Anzeigen();
        }
    }
}