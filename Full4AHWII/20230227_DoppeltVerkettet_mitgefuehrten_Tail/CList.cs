using System;
using System.Collections.Generic;
using System.Text;

namespace _20230227_DoppeltVerkettet
{
    class CList
    {
        //variables
        private CNode _Header;
        private CNode _Tail;

        //construktor
        public CList()
        {
            this._Header = null;
        }

        //encapsulation
        public CNode Header
        {
            get { return _Header; }
            set { _Header = value; }
        }
        public CNode Tail
        {
            get { return _Tail; }
            set { _Tail = value; }
        }
        
        //properties
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

        //methods
        public void InsertF(int Elem)
        {
            //Get an new node
            CNode help = new CNode(Elem);

            //When there is no value in the list
            if (this.Header == null)
            {
                this.Header = help;
                this.Tail = this.Header;
                return;
            } 

            //When there is an value in the list
            help.Next = this.Header;
            this.Header.Prev = help;

            //Set help as the starting position for Header
            this.Header = help;
        }

        public void InsertB(int Elem)
        {
            //Get an new node
            CNode help = new CNode(Elem);

            //When there is no value in the list
            if (this.Header == null)
            {
                this.Header = help;
                this.Tail = this.Header;
                return;
            }

            //Add to the back
            this.Tail.Next = help;
            this.Tail.Next.Prev = this.Tail;
            this.Tail = this.Tail.Next;
        }

        public void InsertIndex(int Elem, int Index)
        {
            //When something is inserted at the start or there is no value in list
            if(Index == 0 || this.Header == null)
            {
                InsertF(Elem);
                return;
            }

            //Variables to work with
            CNode insert_node = new CNode(Elem);
            CNode help = this.Header;

            //Move to the position
            for(int i = 0; i < Index - 1; i++)
            {
                if(help.Next.Next == null)
                {
                    InsertB(Elem);
                    return;
                }

                //Move through the list
                help = help.Next;
            }

            //Connect the middel pice in both lists
            insert_node.Next = help.Next;
            help.Next = insert_node;
            insert_node.Prev = help;
            help.Next.Next.Prev = insert_node;
        }

        public void DeleteF()
        {
            //Remove the first value
            this.Header = this.Header.Next;

            //If the Header is not null remove the previous value
            if(Header != null)
            {
                Header.Prev = null;
            }

            //Set the tail to null if there is no header anymore
            if(this.Header == null)
            {
                this.Tail = null;
            }
        }

        public void DeleteB()
        {
            //When there is no or only one value
            if(this.Header == null || this.Header.Next == null)
            {
                this.Header = null;
                this.Tail = null;
                return;
            }

            //When there are more than one value
            CNode help = this.Header;
            while(help.Next.Next != null)
            {
                help = help.Next;
            }

            //Remove the last value
            help.Next = null;

            //Set the tail
            this.Tail = help;
        }

        public void DeleteIndex(int index)
        {
            CNode help = this.Header;

            //When it is the first node
            if(index == 0)
            {
                DeleteF();
                return;
            }

            //When it is the last node
            if (help.Next == null)
            {
                DeleteB();
                return;
            }

            //Go to the right position
            for (int i = 0; i < index - 1; i++)
            {
                help = help.Next;

                //If we get to the end of the list
                if (help.Next.Next == null)
                {
                    break;
                }
            }

            //Skip the node
            help.Next = help.Next.Next;

            //Check if Tail can be set
            if (help.Next == null)
            {
                this.Tail = help;
            }

            //If there is an next node, set the previous node
            if (help.Next != null)
            {
                help.Next.Prev = help;
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
