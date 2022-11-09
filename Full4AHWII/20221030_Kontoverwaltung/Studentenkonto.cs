using System;
using System.Collections.Generic;
using System.Text;

namespace _20221028_Kontoverwaltung
{
    class Studentenkonto : Konto
    {
        //Variablen
        private double _Quartalsgebuehr;

        //Konstruktoren
        public Studentenkonto(int Kontonummer1, double Zinssatz1, double Gebuehr1) : base(Kontonummer1, Zinssatz1)
        {
            this._Quartalsgebuehr = Gebuehr1;
        }
        public Studentenkonto(int Kontonummer1, double Kontostand1, double Zinssatz1, double Gebuehr1) : base(Kontonummer1, Kontostand1, Zinssatz1)
        {
            this._Quartalsgebuehr = Gebuehr1;
        }

        //Methoden
        public override void Abbuchen(double zum_Entfernen)
        {
            //Verzinsung kontrollieren
            while (DateTime.Now > _Verzinsungsdatum + TimeSpan.FromDays(30 * 3))
            {
                _Kontostand *= (_Zinssatz / 100) + 1;
                _Verzinsungsdatum.Add(TimeSpan.FromDays(30 * 3));
                _Kontostand -= this._Quartalsgebuehr;
            }

            base.Abbuchen(zum_Entfernen);
        }
        public override void Aufbuchen(double zum_Hinzufuegen)
        {
            //Verzinsung kontrollieren
            while (DateTime.Now > _Verzinsungsdatum + TimeSpan.FromDays(30 * 3))
            {
                _Kontostand *= (_Zinssatz / 100) + 1;
                _Verzinsungsdatum.Add(TimeSpan.FromDays(30 * 3));
                _Kontostand -= this._Quartalsgebuehr;
            }

            base.Aufbuchen(zum_Hinzufuegen);
        }
        public override string ToString()
        {
            return "Kontonummer: " + this._Kontonummer + " - " + "Kontostand: " + Math.Round(this._Kontostand, 2) + " - " + "Verzinsungsdatum: " + this._Verzinsungsdatum + " - " + "Zinssatz: " + this._Zinssatz + " - " + "Quartalsgebühr: " + this._Quartalsgebuehr;
        }
    }
}
