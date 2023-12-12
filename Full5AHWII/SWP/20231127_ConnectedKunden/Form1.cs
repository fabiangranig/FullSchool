using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20231127_ConnectedKunden
{
    public partial class Form1 : Form
    {
        private OleDbConnection _OleDBConnection;
        private string _ConnectionString;

        private Kundenuebersicht _Ku;

        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            //Create the connection string
            this._ConnectionString = "Data Source=Nordwind.mdb; Provider=Microsoft.Jet.OLEDB.4.0";
            this._OleDBConnection = new OleDbConnection(this._ConnectionString);

            _Ku = new Kundenuebersicht(this._OleDBConnection);
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kundenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._Ku.ExitStatus == true)
            {
                _Ku = new Kundenuebersicht(this._OleDBConnection);
                _Ku.Size = new Size(100, 100);
                _Ku.MdiParent = this;
                _Ku.Show();
                this.LayoutMdi(MdiLayout.TileHorizontal);
            }
        }
    }
}
