using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240219_Geometrie
{
    class GeometricObject
    {
        private string _Name;
        private int _XBegin;
        private int _YBegin;
        private int _XEnd;
        private int _YEnd;

        public string Name { get { return this._Name; } }
        public int XBegin { get { return this._XBegin; } }
        public int YBegin { get { return this._YBegin; } }
        public int XEnd { get { return this._XEnd; } }
        public int YEnd { get { return this._YEnd; } }

        public GeometricObject(string EingabeName, int EingabeXBegin, int EingabeYBegin, int EingabeXEnd, int EingabeYEnd)
        {
            this._Name = EingabeName;
            this._XBegin = EingabeXBegin;
            this._YBegin = EingabeYBegin;
            this._XEnd = EingabeXEnd;
            this._YEnd = EingabeYEnd;
        }
    }
}
