using System;
using System.Collections.Generic;
using System.Text;

namespace _20221011_MitarbeiterVerwaltung
{
    abstract class Mitarbeiter
    {
        //Variablen
        protected int _SVNR;
        protected string _Name;
        protected string _Adresse;
        protected string _Abteilung;
        protected double _Arbeitszeit;

        //Konstruktoren
        public Mitarbeiter()
        {
            this._SVNR = 0;
            this._Name = "";
            this._Adresse = "";
            this._Abteilung = "";
            this._Arbeitszeit = 0;
        }
        public Mitarbeiter(int SVNR1, string Name1, string Adresse1, string Abteilung1, int Arbeitszeit1)
        {
            this._SVNR = SVNR1;
            this._Name = Name1;
            this._Adresse = Adresse1;
            this._Abteilung = Abteilung1;
            this._Arbeitszeit = Arbeitszeit1;
        }

        //Methode: Personaldaten_anzeigen
        public virtual void Personaldaten_anzeigen()
        {
            Console.WriteLine("Die Personalnummer lautet: " + this._SVNR);
            Console.WriteLine("Der Name lautet: " + this._Name);
            Console.WriteLine("Die Adresse lautet: " + this._Adresse);
            Console.WriteLine("Die Abteilung lautet: " + this._Abteilung);
            Console.WriteLine("Die Arbeitszeit lautet: " + this._Arbeitszeit);
        }

        //Methode: Hat Gehalt
        public abstract double Hat_Gehalt();
    }
}
