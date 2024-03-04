using System;
using System.Collections.Generic;
using System.Text;

namespace _20240304_MeineBibliothek
{
    public class Sort
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
        public string Anzeigen()
        {
            //Mithilfe der for-Schleife ausgeben
            string result = "";
            for (int i = 0; i < this._Liste.Length; i++)
            {
                result += this._Liste[i] + "\n";
            }

            return result;
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
            }
        }
    }
}
