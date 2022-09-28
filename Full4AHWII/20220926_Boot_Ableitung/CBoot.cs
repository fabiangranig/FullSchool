using System;
using System.Collections.Generic;
using System.Text;

namespace _20220926_Boot_Ableitung
{
    class CBoot
    {
        //protected/privat Variablen
        protected string _Name;
        protected double _Laenge;
        protected double _Breite;
        private double _Geschwindigkeit;
        protected double _hoechstGeschwindigkeit;
        protected int _AnzahlInsassen;
        protected int _maximaleInsassen;
        protected double _zugelassenesGesamtgewicht;
        private double _Eigengewicht;

        //Kontruktoren
        public CBoot()
        {
            this._Name = "";
            this._Laenge = 0;
            this._Breite = 0;
            this._hoechstGeschwindigkeit = 0;
            this._maximaleInsassen = 0;
            this._AnzahlInsassen = 0;
            this._zugelassenesGesamtgewicht = 0;
            this._Geschwindigkeit = 0;
            this._Eigengewicht = 0;
        }
        public CBoot(string Name1, double Laenge1, double Breite1, int AnzahlInsassen1, double zugelassenesGesamtgewicht1, double hoechstGeschwindigkeit1, int maximaleInsassen1)
        {
            this._Name = Name1;
            this._Laenge = Laenge1;
            this._Breite = Breite1;
            this._hoechstGeschwindigkeit = hoechstGeschwindigkeit1;
            this._maximaleInsassen = maximaleInsassen1;
            this._AnzahlInsassen = AnzahlInsassen1;
            this._zugelassenesGesamtgewicht = zugelassenesGesamtgewicht1;
            this._Geschwindigkeit = 5;
            this._Eigengewicht = AnzahlInsassen1 * 70 + (AnzahlInsassen1 * 70 * 0.1);
        }

        //Methode Anzeigen
        public virtual void Anzeigen()
        {
            Console.WriteLine("Der Name lautet: " + this._Name);
            Console.WriteLine("Die Länge beträgt: " + this._Laenge);
            Console.WriteLine("Die Breite beträgt: " + this._Breite);
            Console.WriteLine("Die Höchstgeschwindigkeit beträgt: " + this._hoechstGeschwindigkeit);
            Console.WriteLine("Die Geschwindigkeit beträgt: " + this._Geschwindigkeit);

            Console.WriteLine("Die maximale Anzahl der Insassen beträgt: " + this._maximaleInsassen);
            Console.WriteLine("Die Anzahl der Insassen beträgt: " + this._AnzahlInsassen);
            Console.WriteLine("Das zugelassen Gewicht beträgt: " + this._zugelassenesGesamtgewicht);
            Console.WriteLine("Das Eigengewicht beträgt: " + this._Eigengewicht);
        }

        //Methode Zu_oder_entladen
        public void Zu_oder_entladen(double gewicht)
        {
            //Die Geschwindigkeit muss null sein und es muss noch Platz sein
            if(this._Geschwindigkeit == 0 && this._Eigengewicht + gewicht <= _zugelassenesGesamtgewicht)
            {
                this._Eigengewicht += gewicht;
            }
        }

        //Methode Geschwindigkeit_setzen
        public void Geschwindigkeit_setzen(double neue_Geschwindigkeit)
        {
            this._Geschwindigkeit = neue_Geschwindigkeit;
        }
    }
}
