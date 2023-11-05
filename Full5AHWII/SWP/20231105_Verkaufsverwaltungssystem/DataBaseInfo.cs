using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231105_Verkaufsverwaltungssystem
{
    internal class DataBaseInfo
    {
        private static string _ConnectionString;

        static DataBaseInfo() 
        {
            _ConnectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security= true";
        }

        public static string ConnectionString { get { return _ConnectionString; } }
    }
}
