using System;
using System.Collections.Generic;
using System.Text;

namespace Feuerwehr_XX
{
    class Feuerwehrmann : Mitglied
    {
        //Variablen
        protected string _Funktion;
        protected string _Dienstgrad;
        protected double _Einsaetze;
        protected double _Gesamteinsatzdauer;
        protected DateTime _EintrittsdatumFeuerwehrmann;

        //Konstruktor
        public Feuerwehrmann() : base()
        {
            this._Funktion = "Funktion";
            this._Dienstgrad = "Dienstgrad";
            this._Einsaetze = 10;
            this._Gesamteinsatzdauer = 600;
            this._EintrittsdatumFeuerwehrmann = DateTime.Now;
        }
        public Feuerwehrmann(int Mitgliedsnummer, string Vorname, string Nachname, DateTime _Geburtsdatum, string funktion1, string dienstgrad1, int einsaetze1, double gesamteinsatzdauer1, DateTime Beitritt) : base(Mitgliedsnummer, Vorname, Nachname, _Geburtsdatum)
        {
            this._Funktion = funktion1;
            this._Dienstgrad = dienstgrad1;
            this._Einsaetze = einsaetze1;
            this._Gesamteinsatzdauer = gesamteinsatzdauer1;
            this._EintrittsdatumFeuerwehrmann = Beitritt;
        }

        //Kapselung
        public double Gesamteinsatzdauer
        {
            get { return this._Gesamteinsatzdauer; }
        }


        //Methoden
        public override void Mitgliedsdaten_Anzeigen()
        {
            Console.WriteLine("Mitgliedsnummer: " + this._Mitgliednummer + " Vorname: " + this._Vorname + " Nachnahme: " + this._Nachname + " Geburtsdatum: " + this._Geburtsdatum + " Funktion: " + this._Funktion + " Dienstgrad: " + this._Dienstgrad + " Einsätze: " + this._Einsaetze + " Gesamteinsatzdauer: " + this._Gesamteinsatzdauer + " Eintrittsdatum Feuerwehr: " + this._EintrittsdatumFeuerwehrmann);
        }
        public override int Mitgliedsjahre()
        {
            return DateTime.Now.Year - this._EintrittsdatumFeuerwehrmann.Year;
        }
        public double DurchschnittlicheEinsatzdauer()
        {
            return this._Gesamteinsatzdauer / this._Einsaetze;
        }
    }
}
