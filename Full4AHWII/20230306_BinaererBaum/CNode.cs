using System;
using System.Collections.Generic;
using System.Text;

namespace _20230306_BinaererBaum
{
    class CNode
    {
        //Daten
        internal int Element;

        //Verweis
        internal CNode LTeil;
        internal CNode RTeil;

        //Konstruktor
        public CNode(int Elem)
        {
            this.Element = Elem;
            this.LTeil = null;
            this.RTeil = null;
        }
    }
}
