using System;
using System.Collections.Generic;
using System.Text;

namespace _20221031_Vererbung_Abtrakt
{
    class Dreieck : GeoForm
    {
        //Konstruktor
        public Dreieck(double a, double b) : base(a, b, 0) {}

        //Methoden
        public override double flaeche()
        {
            return 0.5 * _breite * Math.Sqrt(Math.Pow(_hoehe, 2) - Math.Pow((_breite / 2), 2));
        }
        public override double umfang()
        {
            return 2 * _hoehe + _breite;
        }
    }
}
