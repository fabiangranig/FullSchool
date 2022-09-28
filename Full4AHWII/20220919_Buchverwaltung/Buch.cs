using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220919_Buchverwaltung
{
    class Buch
    {
        //Private Variablen
        private int BuchNr;
        private string Titel;
        private string Autor;
        private int Stueck;
        private double Stueckpreis;

        //Statische Variable
        private static double GesamtUmsatz;
        private static int verkauft;
        private static int geliefert;

        //Kapselung
        public static double _Gesamtumsatz
        {
            get { return GesamtUmsatz; }
        }
        public static double _verkauft
        {
            get { return verkauft; }
        }
        public static double _geliefert
        {
            get { return geliefert; }
        }

        //Konstructor
        public Buch(int BuchNr1, string Titel1, string Autor1, int Stueck1, double Stueckpreis1)
        {
            this.BuchNr = BuchNr1;
            this.Titel = Titel1;
            this.Autor = Autor1;
            this.Stueck = Stueck1;
            this.Stueckpreis = Stueckpreis1;
        }
        static Buch()
        {
            GesamtUmsatz = 0;
            verkauft = 0;
            geliefert = 0;
        }

        //Funktion: Anzeigen
        public string[] Anzeigen()
        {
            //Den Wert zurückgeben
            string[] arr = new string[5];
            arr[0] = Convert.ToString(this.BuchNr);
            arr[1] = Convert.ToString(this.Titel);
            arr[2] = Convert.ToString(this.Autor);
            arr[3] = Convert.ToString(this.Stueck);
            arr[4] = Convert.ToString(this.Stueckpreis);
            return arr;
        }

        //Funktion: Verkaufen
        public void Verkaufen(int anzahl)
        {
            //Den Wert anpassen
            if(Stueck - anzahl >= 0)
            {
                this.Stueck -= anzahl;
                GesamtUmsatz += anzahl * Stueckpreis;
                verkauft++;
            }
        }

        //Funktion: Lieferung
        public void Lieferung(int anzahl)
        {
            //Den Wert anpassen
            this.Stueck += anzahl;
            geliefert++;
        }

        //Funktion: Lagerumsatz
        public string Lagerumsatz()
        {
            //Den Wert berechnen und zurückgeben
            return Convert.ToString(this.Stueck * this.Stueckpreis);
        }
    }
}
