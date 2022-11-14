using System;
using System.Collections.Generic;
using System.Text;

namespace _20221114_Interface
{
    class Zylinder : Basis_Rund, IGeometric
    {
        //Variablen
        protected double _height;

        //Konstruktor
        public Zylinder(string name1, double height1) : base(name1)
        {
            this._height = height1;
        }
        public Zylinder(string name1, double radius1, double height1) : base(name1, radius1)
        {
            this._height = height1;
        }

        //Methoden
        public double GetArea()
        {
            return Math.Pow(this._radius, 2) * Math.PI;
        }
        public double GetCircum()
        {
            return this._radius * Math.PI;
        }
        public double GetVolume()
        {
            return Math.Pow(this._radius, 2) * Math.PI * this._height;
        }
    }
}
