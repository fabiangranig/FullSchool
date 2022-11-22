using System;
using System.Collections.Generic;
using System.Text;

namespace Feuerwehr_XX
{
    class unterstuetzendesMitglied : Mitglied
    {
        //Variablen
        protected double _Mitgliedsbeitrag;
        protected DateTime _EintrittsdatumUnterstützendesMitglied;

        //Konstruktor
        public unterstuetzendesMitglied() : base()
        {
            this._Mitgliedsbeitrag = 0;
            this._EintrittsdatumUnterstützendesMitglied = DateTime.Now;
        }
        public unterstuetzendesMitglied(int Mitgliedsnummer, string Vorname, string Nachname, DateTime _Geburtsdatum, double mitgliedsbeitrag1, DateTime eintrittsdatumUnterstützendesMitglied1) : base(Mitgliedsnummer, Vorname, Nachname, _Geburtsdatum)
        {
            this._Mitgliedsbeitrag = mitgliedsbeitrag1;
            this._EintrittsdatumUnterstützendesMitglied = eintrittsdatumUnterstützendesMitglied1;
        }

        //Kapselung
        public double Mitgliedbeitrag
        {
            get { return this._Mitgliedsbeitrag; }
        }

        //Methoden
        public override void Mitgliedsdaten_Anzeigen()
        {
            Console.WriteLine("Mitgliedsnummer: " + this._Mitgliednummer + " Vorname: " + this._Vorname + " Nachnahme: " + this._Nachname + " Geburtsdatum: " + this._Geburtsdatum + " Mitgliedsbeitrag: " + this._Mitgliedsbeitrag + " Mitgliedsjahre: " + this._EintrittsdatumUnterstützendesMitglied);
        }
        public override int Mitgliedsjahre()
        {
            return DateTime.Now.Year - this._EintrittsdatumUnterstützendesMitglied.Year;
        }
    }
}
