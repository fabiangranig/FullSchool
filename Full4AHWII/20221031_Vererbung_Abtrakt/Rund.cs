using System;
using System.Collections.Generic;
using System.Text;

namespace _20221031_Vererbung_Abtrakt
{
    abstract class Rund : GeoForm
    {
        //Variablen
        protected string _Farbe;

        //Konstruktor
        public Rund(double hoehe1, double breite1, double radius11, string farbe1) : base(hoehe1, breite1, radius11)
        {
            this._Farbe = farbe1;
        }

        //Kapselung
        public string Farbe
        {
            set { _Farbe = value; }
            get { return _Farbe; }
        }

        //Methoden
        public override string ToString()
        {
            return "Höhe: " + _hoehe + " " + "Breite: " + _breite + " " + "Radius: " + _radius1 + " " + "Farbe: " + _Farbe;
        }
    }
}
