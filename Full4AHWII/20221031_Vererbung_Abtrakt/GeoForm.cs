using System;
using System.Collections.Generic;
using System.Text;

namespace _20221031_Vererbung_Abtrakt
{
    abstract class GeoForm
    {
        //Variablen
        protected double _hoehe;
        protected double _breite;
        protected double _radius1;

        //Konstruktoren
        public GeoForm(double hoehe1, double breite1, double radius11)
        {
            this._hoehe = hoehe1;
            this._breite = breite1;
            this._radius1 = radius11;
        }

        //Kapselung
        public double Hoehe 
        {
            set { _hoehe = value; }
            get { return this._hoehe; }
        }
        public double Breite
        {
            set { this._breite = value; }
            get { return _breite; }
        }
        public double Radius
        {
            set { _radius1 = value; }
            get { return _radius1; }
        }

        //Methoden
        public abstract double flaeche();
        public abstract double umfang();
        public override string ToString()
        {
            return "Höhe: " + _hoehe + " " + "Breite: " + _breite + " " + "Radius: " + _radius1;
        }
    }
}
