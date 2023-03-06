using System;
using System.Collections.Generic;
using System.Text;

namespace _20230220_ConsoleListe
{
    class CNode
    {
        //Konstruktor
        public CNode(int elem)
        {
            this._Element = elem;
            this._Next = null;
        }

        //Kapselung
        public int Element
        {
            get { return _Element; }
            set { _Element = value; }
        }

        public CNode Next
        {
            get { return _Next; }
            set { _Next = value; }
        }

        //Datenteil
        private int _Element;

        //Verweis
        private CNode _Next;
    }
}
