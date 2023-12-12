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

namespace _20231127_ConnectedKunden
{
    public partial class KundenBearbeiten : Form
    {
        private OleDbConnection _OleDBConnection;
        private Modus _Modus;

        public KundenBearbeiten(OleDbConnection oleDbConnection, Modus modus)
        {
            InitializeComponent();
            this._OleDBConnection = oleDbConnection;
            this._Modus = modus;
        }

        public KundenBearbeiten(OleDbConnection oleDbConnection, Modus modus, KundenEintrag kunden)
        {
            InitializeComponent();
            this._OleDBConnection = oleDbConnection;
            this._Modus = modus;
            textBox_KundenCode.Enabled = false;

            //Set starting values
            textBox_KundenCode.Text = kunden.KundenCode;
            textBox_Firma.Text = kunden.Firma;
            textBox_Kontaktperson.Text = kunden.Kontaktperson;
            textBox_Position.Text = kunden.Position;
            textBox_Telephon.Text = kunden.Telefon;
            textBox_Telefax.Text = kunden.Telefax;
            textBox_Strasse.Text = kunden.Strasse;
            textBox_Ort.Text = kunden.Ort;
            textBox_Region.Text = kunden.Region;
            textBox_PLZ.Text = kunden.PLZ;
            textBox_Land.Text = kunden.Land;

            if(this._Modus == Modus.Anzeigen)
            {
                textBox_KundenCode.Visible = false;
                textBox_Firma.Visible = false;
                textBox_Kontaktperson.Visible = false;
                textBox_Position.Visible = false;
                textBox_Telephon.Visible = false;
                textBox_Telefax.Visible = false;
                textBox_Strasse.Visible = false;
                textBox_Ort.Text = kunden.Ort;
                textBox_Region.Text = kunden.Region;
                textBox_PLZ.Text = kunden.PLZ;
                textBox_Land.Text = kunden.Land;
            }
        }

        private void button_Abbrechen_Click(object sender, EventArgs e)
        {
            //Close without changing anything
            this.Close();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            if(this._Modus == Modus.Neu)
            {
                if (textBox_KundenCode.Text != "")
                {
                    //Open the connection
                    _OleDBConnection.Open();

                    //Set the command and execute it
                    OleDbCommand Command = new OleDbCommand();
                    Command.Connection = _OleDBConnection;
                    Command.CommandText = "INSERT INTO Kunden (KundenCode, Firma, Kontaktperson, [Position]," +
                        "Strasse, Ort, Region, PLZ, Land, Telefon, Telefax)" +
                        "VALUES ('" + textBox_KundenCode.Text + "', '" + textBox_Firma.Text + "', '" + textBox_Kontaktperson.Text +
                        "', '" + textBox_Position.Text + "', '" + textBox_Strasse.Text + "', '" + textBox_Ort.Text +
                        "', '" + textBox_Region.Text + "', '" + textBox_PLZ.Text + "', '" + textBox_Land.Text + "', '" + textBox_Telephon.Text +
                        "', '" + textBox_Telefax.Text + "')";
                    Command.ExecuteNonQuery();

                    //Close the connections
                    _OleDBConnection.Close();

                    //Close the windows
                    this.Close();
                }
                else
                {
                    MessageBox.Show("KundenCode is required!");
                }
            }

            if(this._Modus == Modus.Aendern)
            {
                //Open the connection
                _OleDBConnection.Open();

                //Set the command and execute it
                OleDbCommand Command = new OleDbCommand();
                Command.Connection = _OleDBConnection;
                Command.CommandText = "UPDATE Kunden SET Firma = '" + textBox_Firma.Text + "', Kontaktperson = '" + textBox_Kontaktperson.Text + "', [Position] = '"
                    + textBox_Position.Text + "', Strasse = '" + textBox_Strasse.Text + "', Ort = '" + textBox_Ort.Text + "', Region = '"
                    + textBox_Region.Text + "', PLZ = '" + textBox_PLZ.Text + "', Land = '" + textBox_Land.Text + "', Telefon = '" + textBox_Telephon.Text
                    + "', Telefax = '" + textBox_Telefax.Text + "' WHERE KundenCode = '" + textBox_KundenCode.Text + "';";
                Command.ExecuteNonQuery();

                //Close the connections
                _OleDBConnection.Close();

                //Close the windows
                this.Close();
            }
        }
    }
}
