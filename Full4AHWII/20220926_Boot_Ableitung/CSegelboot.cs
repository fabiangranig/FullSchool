using System;
using System.Collections.Generic;
using System.Text;

namespace _20220926_Boot_Ableitung
{
    class CSegelboot : CBoot
    {
        //protected Variablen
        protected double _SegelFlaeche;
        protected int _SegelAnzahl;
        protected double _SegelHoehe;

        //static Variablen
        protected static double _Windgeschwindigkeit;

        //Konstruktoren
        public CSegelboot() : base()
        {
            this._SegelFlaeche = 0;
            this._SegelAnzahl = 0;
            this._SegelHoehe = 0;
        }
        public CSegelboot(double SegelFlaeche1, int SegelAnzahl1, double SegelHoehe1, string Name1, double Laenge1, double Breite1, int AnzahlInsassen1, double zugelassenesGesamtgewicht1, double hoechstGeschwindigkeit1, int maximaleInsassen1) : base(Name1, Laenge1, Breite1, AnzahlInsassen1, zugelassenesGesamtgewicht1, hoechstGeschwindigkeit1, maximaleInsassen1)
        {
            this._SegelFlaeche = SegelFlaeche1;
            this._SegelAnzahl = SegelAnzahl1;
            this._SegelHoehe = SegelHoehe1;
        }
        static CSegelboot()
        {
            _Windgeschwindigkeit = 50;
        }

        //Methode Anzeigen erweitern
        public override void Anzeigen()
        {
            base.Anzeigen();
            Console.WriteLine("Die Segel Fläche beträgt: " + _SegelFlaeche);
            Console.WriteLine("Die Segel Anzahl beträgt: " + _SegelAnzahl);
            Console.WriteLine("Die Segel Höhe beträgt: " + _SegelHoehe);
        }

        //Methode SegelFlaecheAendern
        public void SegelFlaecheAendern(bool schalter)
        {
            if(schalter == true)
            {
                Geschwindigkeit_setzen(_Windgeschwindigkeit);
            }
            else
            {
                Geschwindigkeit_setzen(0);
            }
        }
    }
}