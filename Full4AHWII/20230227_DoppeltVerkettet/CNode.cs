using System;
using System.Collections.Generic;
using System.Text;

namespace _20230227_DoppeltVerkettet
{
    class CNode
    {
        //Konstruktor
        public CNode(int elem)
        {
            this._Element = elem;
            this._Next = null;
            this._Prev = null;
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
        public CNode Prev
        {
            get { return _Prev; }
            set { _Prev = value; }
        }

        //Datenteil
        private int _Element;

        //Verweis
        private CNode _Next;
        private CNode _Prev;
    }
}
