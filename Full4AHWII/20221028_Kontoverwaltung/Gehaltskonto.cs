﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _20221028_Kontoverwaltung
{
    class Gehaltskonto : Konto
    {
        //Variablen
        private int _AnzahlAbbuchung;
        private double _GebuehrProAbbuchung;

        //Konstruktoren
        public Gehaltskonto(int Kontonummer1, double Zinssatz1, double Gebuehr1) : base(Kontonummer1, Zinssatz1)
        {
            this._GebuehrProAbbuchung = Gebuehr1;
        }
        public Gehaltskonto(int Kontonummer1, double Kontostand1, double Zinssatz1, double Gebuehr1) : base(Kontonummer1, Kontostand1, Zinssatz1)
        {
            this._GebuehrProAbbuchung = Gebuehr1;
        }

        //Methoden
        public override void Aufbuchen(double zum_Hinzufuegen)
        {
            base.Aufbuchen(zum_Hinzufuegen);

            this._AnzahlAbbuchung++;

            //Verzinsung kontrollieren
            while(new DateTime(2024, 1, 1) > _Verzinsungsdatum + TimeSpan.FromDays(365))
            {
                _Kontostand *= (_Zinssatz / 100) + 1;
                _Verzinsungsdatum += TimeSpan.FromDays(365);
                _Kontostand -= (_AnzahlAbbuchung * _GebuehrProAbbuchung);
                this._AnzahlAbbuchung = 0;
            }
        }
        public override void Abbuchen(double zum_Entfernen)
        {
            base.Abbuchen(zum_Entfernen);

            this._AnzahlAbbuchung++;

            //Verzinsung kontrollieren
            while (new DateTime(2024, 1, 1) > _Verzinsungsdatum + TimeSpan.FromDays(365))
            {
                _Kontostand *= (_Zinssatz / 100) + 1;
                _Verzinsungsdatum += TimeSpan.FromDays(365);
                _Kontostand -= (_AnzahlAbbuchung * _GebuehrProAbbuchung);
                this._AnzahlAbbuchung = 0;
            }
        }
        public override string ToString1()
        {
            return "Kontonummer: " + this._Kontonummer + " - " + "Kontostand: " + this._Kontostand + " - " + "Verzinsungsdatum: " + this._Verzinsungsdatum + " - " + "Zinssatz: " + this._Zinssatz + " - " + "Gebühr: " + this._GebuehrProAbbuchung + " - " + "Anzahl Abbuchungen: " + this._AnzahlAbbuchung;
        }
    }
}
