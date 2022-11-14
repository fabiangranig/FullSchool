using System;
using System.Collections.Generic;
using System.Text;

namespace _20221114_Interface
{
    class Basis_Rund
    {
        //Variablen
        protected double _radius;
        protected string _name;

        //Konstruktor
        public Basis_Rund(string name1)
        {
            this._name = name1;
            this._radius = 0;
        }
        public Basis_Rund(string name1, double radius1)
        {
            this._name = name1;
            this._radius = radius1;
        }
    }
}
