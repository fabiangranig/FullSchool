using System;
using System.Collections.Generic;
using System.Text;

namespace _20221114_Interface
{
    class Cube : IGeometric
    {
        //Variablen
        protected string _name;
        protected double _sideLength;

        //Kontruktor
        public Cube(string name1, double sideLength1)
        {
            this._name = name1;
            this._sideLength = sideLength1;
        }

        //Methoden
        public double GetArea()
        {
            return this._sideLength * this._sideLength;
        }
        public double GetCircum()
        {
            return this._sideLength * 4;
        }
        public double GetVolume()
        {
            return Math.Pow(this._sideLength, 3);
        }
    }
}
