using System;
using System.Collections.Generic;
using System.Text;

namespace _20221031_Vererbung_Abtrakt
{
    class Quadrat : Viereck
    {
        //Konstruktor
        public Quadrat(double laenge_a) : base(laenge_a, laenge_a) { }
    }
}
