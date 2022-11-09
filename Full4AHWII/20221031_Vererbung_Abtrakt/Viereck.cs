using System;
using System.Collections.Generic;
using System.Text;

namespace _20221031_Vererbung_Abtrakt
{
    class Viereck : GeoForm
    {
        //Konstruktor
        public Viereck(double hoehe1, double breite1) : base(hoehe1, breite1, 0) { }

        //Methoden
        public override double flaeche()
        {
            return _hoehe * _breite;
        }
        public override double umfang()
        {
            return (2 * _hoehe) + (2 * _breite);
        }
    }
}
