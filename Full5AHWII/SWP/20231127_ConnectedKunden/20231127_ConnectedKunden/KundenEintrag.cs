using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231127_ConnectedKunden
{
    internal class KundenEintrag
    {
        private string _KundenCode;
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

        public string KundenCode { get { return _KundenCode;} }
        public string Firma { get { return _Firma;} }
        public string Kontaktperson { get {  return _Kontaktperson;} }
        public string Position { get { return _Position; } }
        public string Strasse { get { return _Strasse;} }
        public string Ort { get { return _Ort; } }
        public string Region { get { return _Region;} }
        public string PLZ { get { return _PLZ;} }
        public string Land { get { return _Land;} }
        public string Telefon { get { return _Telefon;} }
        public string Telefax { get { return _Telefax;} }

        public KundenEintrag(string kundenCode, string firma, string kontaktperson, string position, string strasse, string ort, string region, string pLZ, string land, string telefon, string telefax)
        {
            this._KundenCode = kundenCode;
            this._Firma = firma;
            this._Kontaktperson = kontaktperson;
            this._Position = position;
            this._Strasse = strasse;
            this._Ort = ort;
            this._Region = region;
            this._PLZ = pLZ;
            this._Land = land;
            this._Telefon = telefon;
            this._Telefax = telefax;
        }
    }
}
