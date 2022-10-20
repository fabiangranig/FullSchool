using System;
using System.Collections.Generic;
using System.Text;

namespace _20221011_MitarbeiterVerwaltung
{
    class Arbeiter : Mitarbeiter
    {
        //Variablen
        protected double _Stundenlohn;

        //Konstruktoren
        public Arbeiter() : base()
        {
            this._Stundenlohn = 1;
        }
        public Arbeiter(int SVNR1, string Name1, string Adresse1, string Abteilung1, int Arbeitszeit1, double Stundenlohn1) : base(SVNR1, Name1, Adresse1, Abteilung1, Arbeitszeit1)
        {
            this._Stundenlohn = Stundenlohn1;
        }

        //Methode: Hat_Gehalt
        public override double Hat_Gehalt()
        {
            return this._Stundenlohn * 30;
        }

        //Methode: Personaldaten_anzeigen
        public override void Personaldaten_anzeigen()
        {
            base.Personaldaten_anzeigen();
            Console.WriteLine("Der Monatslohn beträgt: " + (this._Stundenlohn*30));
        }
    }
}
