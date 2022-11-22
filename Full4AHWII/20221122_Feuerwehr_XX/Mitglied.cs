using System;
using System.Collections.Generic;
using System.Text;

namespace Feuerwehr_XX
{
    abstract class Mitglied
    {
        //Variablen
        protected int _Mitgliednummer;
        protected string _Vorname;
        protected string _Nachname;
        protected DateTime _Geburtsdatum;

        //Konstruktor
        public Mitglied()
        {
            this._Mitgliednummer = 9999999;
            this._Vorname = "Vorname";
            this._Nachname = "Nachname";
            this._Geburtsdatum = DateTime.Now;
        }
        public Mitglied(int Mitgliedsnummer, string Vorname, string Nachname, DateTime _Geburtsdatum)
        {
            this._Mitgliednummer = Mitgliedsnummer;
            this._Vorname = Vorname;
            this._Nachname = Nachname;
            this._Geburtsdatum = _Geburtsdatum;
        }

        //Methoden
        public abstract void Mitgliedsdaten_Anzeigen();
        public abstract int Mitgliedsjahre();
    }
}
