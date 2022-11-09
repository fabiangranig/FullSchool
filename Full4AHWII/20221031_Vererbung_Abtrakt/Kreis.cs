using System;
using System.Collections.Generic;
using System.Text;

namespace _20221031_Vererbung_Abtrakt
{
    class Kreis : Rund
    {
        //Konstruktor
        public Kreis(double radius11, string farbe1) : base(0, 0, radius11, farbe1) { }

        //Methoden
        public override double flaeche()
        {
            return Math.Pow(_radius1, 2) * Math.PI;
        }
        public override double umfang()
        {
            return _radius1 * Math.PI;
        }
    }
}
