﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _20230227_DoppeltVerkettet
{
    class CList
    {
        //Variablen
        private CNode _Header;

        //Konstrukor
        public CList()
        {
            this._Header = null;
        }

        //Kapselung
        public CNode Header
        {
            get { return _Header; }
            set { _Header = value; }
        }
        public CNode Tail
        {
            get
            {
                CNode help = this.Header;
                if(help == null)
                {
                    return null;
                }

                while(help.Next != null)
                {
                    help = help.Next;
                }

                return help;
            }
        }
        public int Length
        {
            get
            {
                int laenge = 0;
                CNode help = this.Header;
                while (help != null)
                {
                    help = help.Next;
                    laenge++;
                }

                return laenge;
            }
        }

        //Methoden
        public void InsertF(int Elem)
        {
            CNode help = new CNode(Elem);
            help.Next = this.Header;
            if(this.Header != null)
            {
                this.Header.Prev = help;
            }
            this.Header = help;
        }

        public void InsertB(int Elem)
        {
            CNode n1 = new CNode(Elem);

            if (this.Header == null)
            {
                this.Header = n1;
            }
            else
            {
                CNode help = this.Header;
                while (help.Next != null)
                {
                    help = help.Next;
                }
                help.Next = n1;
                n1.Prev = help;
            }
        }

        public void InsertIndex(int Elem, int Index)
        {
            if (Index == 0 || this.Header == null)
            {
                InsertF(Elem);
            }
            else
            {
                CNode n1 = new CNode(Elem);
                CNode help = this.Header;
                for (int i = 0; i < Index - 1; i++)
                {
                    if (help.Next == null)
                    {
                        break;
                    }

                    help = help.Next;
                }
                n1.Next = help.Next;

                if(help.Next != null)
                {
                    help.Next.Prev = n1;
                }

                help.Next = n1;
                n1.Prev = help;
            }
        }

        public void DeleteF()
        {
            Header = Header.Next;

            if(Header != null)
            {
                Header.Prev = null;
            }
        }

        public void DeleteB()
        {
            CNode help = this.Header;
            if(help == null)
            {

            }
            if(help.Next == null)
            {
                DeleteF();
            }
            else
            {
                while (help.Next.Next != null)
                {
                    help = help.Next;
                }

                help.Next = null;
            }
        }

        public void DeleteIndex(int index)
        {
            CNode help = this.Header;
            if (index == 0)
            {
                DeleteF();
            }
            else
            {
                if(help.Next == null)
                {
                    DeleteB();
                }
                else
                {
                    for (int i = 0; i < index - 1; i++)
                    {
                        help = help.Next;

                        if (help.Next.Next == null)
                        {
                            break;
                        }
                    }
                    help.Next = help.Next.Next;

                    if (help.Next != null)
                    {
                        help.Next.Prev = help;
                    }
                }
            }
        }

        public int CNodeatIndex(int index)
        {
            CNode temp = Header;
            for (int i = 0; i < index; i++)
            {
                if (temp.Next == null)
                {
                    break;
                }

                temp = temp.Next;
            }
            return temp.Element;
        }

        public void Tauschen(int index1, int index2)
        {
            int box1 = CNodeatIndex(index1);
            int box2 = CNodeatIndex(index2);
            if (index1 != index2)
            {
                DeleteIndex(index2);
                InsertIndex(box1, index2);

                DeleteIndex(index1);
                InsertIndex(box2, index1);
            }
        }

        public void BubbleSort()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int u = 0; u < Length; u++)
                {
                    if (CNodeatIndex(i) < CNodeatIndex(u))
                    {
                        Tauschen(u, i);
                    }
                }
            }
        }

        public void QuickSort()
        {
            QuickSortwithRange(0, Length);
        }

        public void QuickSortwithRange(int unten, int oben)
        {
            if (unten < oben)
            {
                int u = unten - 1;
                int o = oben;
                int elem = CNodeatIndex(oben);

                do
                {
                    while (u < oben && CNodeatIndex(++u) < elem) ;
                    while (o > 0 && CNodeatIndex(--o) >= elem) ;
                    if (u >= o)
                        break;

                    Tauschen(u, o);
                } while (u < o);

                Tauschen(u, oben);

                QuickSortwithRange(unten, u - 1);
                QuickSortwithRange(u + 1, oben);
            }
        }

        public void Anzeigen()
        {
            CNode help = this.Header;

            while (help != null)
            {
                Console.WriteLine("{0}", help.Element);
                help = help.Next;
            }
        }
        public void AnzeigenPrev()
        {
            CNode help = Tail;

            while (help != null)
            {
                Console.WriteLine("{0}", help.Element);
                help = help.Prev;
            }
        }
    }
}
