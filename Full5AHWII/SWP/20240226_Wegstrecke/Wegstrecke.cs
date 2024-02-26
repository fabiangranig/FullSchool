using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Threading;

namespace _20240226_Wegstrecke
{
    public partial class Wegstrecke : Form
    {
        //Parameter ohne String Concenation
        //Thread: Summe alle 3 Sekunden aktualisieren
        //Thread: auch Änderungen zeigen die in einem anderen Programm gemacht werden

        private Thread _ThreadUpdate;
        private DataTable _DataTableLieferant;

        public Wegstrecke()
        {
            InitializeComponent();
            GetDataFromTable();

            //Start Thread to Update Data
            this._ThreadUpdate = new Thread(InformationUpdater);
            this._ThreadUpdate.Start();
        }

        private void InformationUpdater()
        {
            while(true)
            {

                Thread.Sleep(3000);
            }
        }

        private void GetDataFromTable()
        {
            string connectionstring = "Data Source=Wegstrecken.mdb; Provider=Microsoft.Jet.OLEDB.4.0";
            OleDbConnection oleDbConnection = new OleDbConnection(connectionstring);

            oleDbConnection.Open();
            OleDbCommand Command = new OleDbCommand();
            Command.Connection = oleDbConnection;
            Command.CommandText = "SELECT * FROM Lieferungen;";
            OleDbDataReader DataReader = Command.ExecuteReader();

            //Load table into dataGridView
            this._DataTableLieferant.Load(DataReader);
            dataGridView1.DataSource = this._DataTableLieferant;

            //Set some columns to read only
            this.dataGridView1.Columns["Nummer"].ReadOnly = true;
            this.dataGridView1.Columns["Kunde"].ReadOnly = true;

            oleDbConnection.Close();
        }
    }
}
