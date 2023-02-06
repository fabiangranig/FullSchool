using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20221129_Sortieren
{
    class Sort
    {
        //Variablen
        private int[] _Liste;

        //Kontruktor
        public Sort(int[] liste1)
        {
            this._Liste = liste1;
        }

        //Kapselung
        public int[] Liste
        {
            get { return this._Liste; }
        }

        //Methoden
        public void Anzeigen()
        {
            //Mithilfe der for-Schleife ausgeben
            for (int i = 0; i < this._Liste.Length; i++)
            {
                Console.Write(this._Liste[i] + " ");
            }
        }

        public void BubbleSort()
        {
            for (int i = 0; i < this._Liste.Length; i++)
            {
                for (int u = 0; u < this._Liste.Length - 1; u++)
                {
                    //Werte tauschen wenn nötig
                    if (this._Liste[u] > this._Liste[u + 1])
                    {
                        int copy = this._Liste[u];
                        this._Liste[u] = this._Liste[u + 1];
                        this._Liste[u + 1] = copy;
                    }
                }
            }
        }

        public void SortierenDurchAuswahl()
        {
            for (int i = 0; i < this._Liste.Length; i++)
            {
                int start_value = i;
                int kleinstes = Int32.MaxValue;
                int kleinstes_index = -1;
                for (int u = start_value; u < this._Liste.Length; u++)
                {
                    if (kleinstes >= this._Liste[u])
                    {
                        kleinstes = this._Liste[u];
                        kleinstes_index = u;
                    }
                }

                //Elemente werden getauscht
                int temp = this._Liste[i];
                this._Liste[i] = this._Liste[kleinstes_index];
                this._Liste[kleinstes_index] = temp;
            }
        }

        public void SortierenDurchEinfuegen()
        {
            for (int i = 1; i < this._Liste.Length; i++)
            {
                int wert_zum_einfuegen = this._Liste[i];
                int u = i - 1;

                while (u >= 0 && this._Liste[u] > wert_zum_einfuegen)
                {
                    this._Liste[u + 1] = this._Liste[u];
                    u = u - 1;
                }

                this._Liste[u + 1] = wert_zum_einfuegen;

                Console.Write((i) + ".Schritt: ");
                Anzeigen();
                Console.Write("\n");
            }
        }

        public void QuickSort()
        {
            QuickSort1(0, this._Liste.Length - 1);
        }

        private void QuickSort1(int unten, int oben)
        {
            if (unten < oben)
            {
                int u = unten - 1;
                int o = oben;
                int elem = this._Liste[oben];

                do
                {
                    while (u < oben && this._Liste[++u] < elem) ;
                    while (o > 0 && this._Liste[--o] >= elem) ;
                    if (u >= o)
                        break;

                    tauschen(u, o);
                } while (u < o);

                tauschen(u, oben);

                QuickSort1(unten, u - 1);
                QuickSort1(u + 1, oben);
            }
        }

        private void tauschen(int index1, int index2)
        {
            int temp = this._Liste[index1];
            this._Liste[index1] = this._Liste[index2];
            this._Liste[index2] = temp;
        }
    }
}
