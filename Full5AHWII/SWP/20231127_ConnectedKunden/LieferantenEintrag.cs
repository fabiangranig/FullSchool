using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231127_ConnectedKunden
{
    public class LieferantenEintrag
    {
        private string _Lieferanten_Nr;
        private string _Firma;
        private string _Kontaktperson;
        private string _Position;
        private string _Strasse;
        private string _Ort;
        private string _Region;
        private string _PLZ;
        private string _Land;
        private string _Telefon;
        private string _Telefax;
        private string _Website;

        public string Lieferanten_Nr { get { return _Lieferanten_Nr; } }
        public string Firma { get { return _Firma; } }
        public string Kontaktperson { get { return _Kontaktperson; } }
        public string Position { get { return _Position; } }
        public string Strasse { get { return _Strasse; } }
        public string Ort { get { return _Ort; } }
        public string Region { get { return _Region; } }
        public string PLZ { get { return _PLZ; } }
        public string Land { get { return _Land; } }
        public string Telefon { get { return _Telefon; } }
        public string Telefax { get { return _Telefax; } }

        public string Website { get { return _Website; } }

        public LieferantenEintrag(string LieferantenNr1, string Firma1, string Kontaktperson1, string Position1, string Strasse1, string Ort1, 
            string Region1, string PLZ1, string Land1, string Telefon1, string Telefax1, string Website1)
        {
            this._Lieferanten_Nr = LieferantenNr1;
            this._Firma = Firma1;
            this._Kontaktperson = Kontaktperson1;
            this._Position = Position1;
            this._Strasse = Strasse1;
            this._Ort = Ort1;
            this._Region = Region1;
            this._PLZ = PLZ1;
            this._Land = Land1;
            this._Telefon = Telefon1;
            this._Telefax = Telefax1;
            this._Website = Website1;
        }
    }
}
