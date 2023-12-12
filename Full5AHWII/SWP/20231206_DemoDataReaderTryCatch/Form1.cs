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

namespace _2023115_DemoDataReader
{
    public partial class Form1 : Form
    {
        private OleDbConnection _OleDBConnection;
        private string _ConnectionString;

        public Form1()
        {
            InitializeComponent();

            //Set the connection string and create the OleDBConnection
            _ConnectionString = "Data Source=Demo.mdb; Provider=Microsoft.Jet.OLEDB.4.0";
            _OleDBConnection = new OleDbConnection(_ConnectionString);
        }

        private void button_Beenden_Click(object sender, EventArgs e)
        {
            //Close the app
            this.Close();
        }

        private void button_Verbinden_Click(object sender, EventArgs e)
        {
            //Open the connection
            try 
            {
                _OleDBConnection.Open();
            }
            catch(InvalidOperationException ex)
            {
                MessageBox.Show("Verbindung bereits geöffnet:" + ex.Message);
            }
            catch(OleDbException ex)
            {
                MessageBox.Show("Fehler bei Verbindung: " + ex.Message);
            }
        }

        private void button_Schliessen_Click(object sender, EventArgs e)
        {
            //Close the connection
            _OleDBConnection.Close();
            MessageBox.Show("Connection Status: " + _OleDBConnection.State.ToString());
        }

        private void button_TabelleErzeugen_Click(object sender, EventArgs e)
        {
            OleDbCommand Command = new OleDbCommand();
            Command.Connection = _OleDBConnection;
            Command.CommandText = "CREATE TABLE test1 (Nummer int primary key, Bezeichnung text)";

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }
        }

        private void button_TabelleLoeschen_Click(object sender, EventArgs e)
        {
            OleDbCommand Command = new OleDbCommand();
            Command.Connection = _OleDBConnection;
            Command.CommandText = "DROP TABLE test1";

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }
        }

        private void buttonDatenEinfuegen_Click(object sender, EventArgs e)
        {
            OleDbCommand Command = new OleDbCommand();
            Command.Connection = _OleDBConnection;
            Command.CommandText = "INSERT INTO test1 (Nummer, Bezeichnung) VALUES (1, 'Test1')";

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }

            Command.CommandText = "INSERT INTO test1 (Nummer, Bezeichnung) VALUES (2, 'Test2')";

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }

            Command.CommandText = "INSERT INTO test1 (Nummer, Bezeichnung) VALUES (3, 'Test3')";

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }
        }

        private void button_DatenAuslesen_Click(object sender, EventArgs e)
        {
            OleDbCommand Command = new OleDbCommand();
            Command.Connection = _OleDBConnection;
            Command.CommandText = "SELECT * FROM test1";

            try
            {
                this.listView_AusgeleseneDaten.Items.Clear();
                this.listView_AusgeleseneDaten.Columns.Clear();

                OleDbDataReader DataReader = Command.ExecuteReader();
                this.listView_AusgeleseneDaten.Columns.Add("Nummer");
                this.listView_AusgeleseneDaten.Columns.Add("Bezeichnung");

                while (DataReader.Read())
                {
                    this.listView_AusgeleseneDaten.Items.Add(new ListViewItem(new string[2] { DataReader.GetInt32(0).ToString(), DataReader.GetString(1) }));
                }
                DataReader.Close();
            }
            catch(InvalidOperationException ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }
            catch(InvalidCastException ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }
        }
    }
}
