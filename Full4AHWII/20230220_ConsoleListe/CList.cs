using System;
using System.Collections.Generic;
using System.Text;

namespace _20230220_ConsoleListe
{
    class CList
    {
        private CNode _Header;

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
            this.Header = help;
        }

        public void InsertB(int Elem)
        {
            CNode n1 = new CNode(Elem);

            if(this.Header == null)
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
            }
        }

        public void InsertIndex(int Elem, int Index)
        {
            if(Index == 0)
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
                help.Next = n1;
            }
        }

        public void DeleteF()
        {
            Header = Header.Next;
        }

        public void DeleteB()
        {
            CNode help = this.Header;
            while (help.Next.Next != null)
            {
                help = help.Next;
            }
            help.Next = null;
        }

        public void DeleteIndex(int index)
        {
            if(index == 0)
            {
                DeleteF();
            }
            else
            {
                CNode help = this.Header;
                for (int i = 0; i < index - 1; i++)
                {
                    help = help.Next;

                    if(help.Next.Next == null)
                    {
                        break;
                    }
                }
                help.Next = help.Next.Next;
            }
        }

        public int CNodeatIndex(int index)
        {
            CNode temp = Header;
            for(int i = 0; i < index; i++)
            {
                if(temp.Next == null)
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
            for(int i = 0; i < Length; i++)
            {
                for(int u = 0; u < Length; u++)
                {
                    if(CNodeatIndex(i) < CNodeatIndex(u))
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

            while(help != null)
            {
                Console.WriteLine("{0}", help.Element);
                help = help.Next;
            }
        }
    }
}
