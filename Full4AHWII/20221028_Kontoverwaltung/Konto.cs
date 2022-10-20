using System;
using System.Collections.Generic;
using System.Text;

namespace _20221028_Kontoverwaltung
{
    class Konto
    {
        //Variablen
        protected int _Kontonummer;
        protected double _Kontostand;
        public DateTime _Verzinsungsdatum;
        protected double _Zinssatz;

        //Konstruktoren
        public Konto(int Kontonummer1, double Zinssatz1)
        {
            this._Kontonummer = Kontonummer1;
            this._Kontostand = 0;
            this._Verzinsungsdatum = DateTime.Now;
            this._Zinssatz = Zinssatz1;
        }
        public Konto(int Kontonummer1, double Kontostand1, double Zinssatz1)
        {
            this._Kontonummer = Kontonummer1;
            this._Kontostand = Kontostand1;
            this._Verzinsungsdatum = DateTime.Now;
            this._Zinssatz = Zinssatz1;
        }

        //Methoden
        public virtual void Aufbuchen(double zum_Hinzufuegen)
        {
            this._Kontostand += zum_Hinzufuegen;
        }
        public virtual void Abbuchen(double zum_Entfernen)
        {
            this._Kontostand -= zum_Entfernen;
        }
        public double KontostandAnzeigen()
        {
            //Den Kontostand zurückgeben
            return Math.Round(this._Kontostand, 2);
        }
        public virtual string ToString1()
        {
            //Alles zusammenfügen und zurückgeben
            return "Kontonummer: " + this._Kontonummer + " - " + "Kontostand: " + this._Kontostand + " - " + "Verzinsungsdatum: " + this._Verzinsungsdatum + " - " + "Zinssatz: " + this._Zinssatz;
        }
    }
}
