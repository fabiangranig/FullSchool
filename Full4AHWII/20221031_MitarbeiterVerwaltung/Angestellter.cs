using System;
using System.Collections.Generic;
using System.Text;

namespace _20221011_MitarbeiterVerwaltung
{
    class Angestellter : Mitarbeiter
    {
        //Variablen
        protected double _Monatslohn;

        //Konstruktoren
        public Angestellter() : base()
        {
            this._Monatslohn = 1;
        }
        public Angestellter(int SVNR1, string Name1, string Adresse1, string Abteilung1, int Arbeitszeit1, double Monatslohn1) : base(SVNR1, Name1, Adresse1, Abteilung1, Arbeitszeit1)
        {
            this._Monatslohn = Monatslohn1;
        }

        //Methode: Hat_Gehalt
        public override double Hat_Gehalt()
        {
            return this._Monatslohn;
        }

        //Methode: Personaldaten_anzeigen
        public override void Personaldaten_anzeigen()
        {
            base.Personaldaten_anzeigen();
            Console.WriteLine("Der Monatslohn beträgt: " + this._Monatslohn);
        }
    }
}
