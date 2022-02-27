//Fabian Granig 3AHWII
//21.02.2022
//Beispiel: Schüler
using System;

namespace _20220221_Schueler
{
    //Klasse: Schüler
    class Schueler
    {
        //Variablen anlegen
        private string vorname;
        private string nachname;
        private string geburtsdatum;
        private string e_mail;
        private string telefonnummer;

        //Standart Konstruktoren anlegen
        public Schueler(string avorname, string anachname, string ageburtsdatum)
        {
            this.vorname = avorname;
            this.nachname = anachname;
            this.geburtsdatum = ageburtsdatum;
            this.e_mail = "none";
            this.telefonnummer = "none";
        }

        public Schueler(string avorname, string anachname, string ageburtsdatum, string ae_mail, string atelefonnummer)
        {
            this.vorname = avorname;
            this.nachname = anachname;
            this.geburtsdatum = ageburtsdatum;
            this.e_mail = ae_mail;
            this.telefonnummer = atelefonnummer;
        }

        //Kapselungen anlegen
        public string Vorname
        {
            get { return vorname; }
        }
        public string Nachname
        {
            get { return nachname; }
            set { nachname = value; }
        }
        public string Geburtsdatum 
        { 
            get { return geburtsdatum; }
        }
        public string E_Mail
        {
            get { return e_mail; }
            set { e_mail = value; }
        }
        public string Telefonnummer
        {
            get { return telefonnummer; }
            set { telefonnummer = value; }
        }

        //Methode: Ausgabe
        public void Ausgabe()
        {
            Console.WriteLine("Vorname: " + this.vorname);
            Console.WriteLine("Nachname: " + this.nachname);
            Console.WriteLine("Geburtsdatum: "  + this.geburtsdatum);
            Console.WriteLine("E-Mail: " + this.e_mail);
            Console.WriteLine("Telefonnummer: " + this.telefonnummer);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Erstellen eines Schülers
            Schueler s1 = new Schueler("Fabian", "Granig", "01.12.2004", "fabian@gmail.com", "067712345678");

            //Ausgabe
            Console.WriteLine("Ausgabe der Werte des Schülers: ");
            s1.Ausgabe();

            //leere Zeile
            Console.WriteLine("");

            //Ändern der Eigenschaften
            //s1.Vorname = "Elias";
            s1.Nachname = "Grenig";
            //s1.Geburtsdatum = "01.13.2005";
            s1.E_Mail = "fabian123@gmail.com";
            s1.Telefonnummer = "0677987654321";

            //leere Zeile
            Console.WriteLine("");

            //erneutes Ausgeben
            Console.WriteLine("Ausgabe der Werte des Schülers: ");
            s1.Ausgabe();
        }
    }
}
