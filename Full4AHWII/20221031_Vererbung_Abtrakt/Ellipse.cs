using System;
using System.Collections.Generic;
using System.Text;

namespace _20221031_Vererbung_Abtrakt
{
    class Ellipse : Rund
    {
        //Konstruktoren
        public Ellipse(double radius_a, double radius_b, string farbe1) : base(radius_a, radius_b, 0, farbe1) {}

        //Methode
        public override double flaeche()
        {
            return _hoehe * _breite * Math.PI;
        }
        public override double umfang()
        {
            double jing = ((_hoehe - _breite) / (_hoehe + _breite));
            return ((_hoehe + _breite) * Math.PI * (1 + ((3 * Math.Pow(jing, 2)) / (10 + Math.Sqrt(4 - 3 * Math.Pow(jing, 2))))));
        }
    }
}
