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
    public partial class LieferantenBearbeiten : Form
    {
        private OleDbConnection _OleDBConnection;
        private Modus _Modus;

        public LieferantenBearbeiten(OleDbConnection oleDbConnection, Modus modus)
        {
            InitializeComponent();
            this._OleDBConnection = oleDbConnection;
            this._Modus = modus;
        }

        public LieferantenBearbeiten(OleDbConnection oleDbConnection, Modus modus, LieferantenEintrag kunden)
        {
            InitializeComponent();
            this._OleDBConnection = oleDbConnection;
            this._Modus = modus;
            textBox_KundenCode.Enabled = false;

            //Set starting values
            textBox_KundenCode.Text = Convert.ToString(kunden.Lieferanten_Nr);
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
            textBox_Website.Text = kunden.Website;

            if (this._Modus == Modus.Anzeigen)
            {
                textBox_KundenCode.Enabled = false;
                textBox_Firma.Enabled = false;
                textBox_Kontaktperson.Enabled = false;
                textBox_Position.Enabled = false;
                textBox_Telephon.Enabled = false;
                textBox_Telefax.Enabled = false;
                textBox_Strasse.Enabled = false;
                textBox_Ort.Enabled = false;
                textBox_Region.Enabled = false;
                textBox_PLZ.Enabled = false;
                textBox_Land.Enabled = false;
                textBox_Website.Enabled = false;
            }
        }

        private void button_Abbrechen_Click(object sender, EventArgs e)
        {
            //Close without changing anything
            this.Close();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            if (this._Modus == Modus.Neu)
            {
                if (textBox_KundenCode.Text != "")
                {
                    //Open the connection
                    _OleDBConnection.Open();

                    //Set the command and execute it
                    OleDbCommand Command = new OleDbCommand();
                    Command.Connection = _OleDBConnection;
                    Command.CommandText = "INSERT INTO Lieferanten ([Lieferanten-Nr], Firma, Kontaktperson, [Position]," +
                        "Straße, Ort, Region, PLZ, Land, Telefon, Telefax, Homepage)" +
                        "VALUES ('" + textBox_KundenCode.Text + "', '" + textBox_Firma.Text + "', '" + textBox_Kontaktperson.Text +
                        "', '" + textBox_Position.Text + "', '" + textBox_Strasse.Text + "', '" + textBox_Ort.Text +
                        "', '" + textBox_Region.Text + "', '" + textBox_PLZ.Text + "', '" + textBox_Land.Text + "', '" + textBox_Telephon.Text +
                        "', '" + textBox_Telefax.Text + "', '" + textBox_Website.Text +  "')";

                    Command.ExecuteNonQuery();

                    try
                    {
                        

                        //Close the connections
                        _OleDBConnection.Close();

                        //Close the windows
                        this.Close();
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("Der Primärschlüssel existiert schon!");

                        //Close the connections
                        _OleDBConnection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("KundenCode is required!");
                }
            }

            if (this._Modus == Modus.Aendern)
            {
                //Open the connection
                _OleDBConnection.Open();

                //Set the command and execute it
                OleDbCommand Command = new OleDbCommand();
                Command.Connection = _OleDBConnection;
                Command.CommandText = "UPDATE Lieferanten SET Firma = '" + textBox_Firma.Text + "', Kontaktperson = '" + textBox_Kontaktperson.Text + "', [Position] = '"
                    + textBox_Position.Text + "', Straße = '" + textBox_Strasse.Text + "', Ort = '" + textBox_Ort.Text + "', Region = '"
                    + textBox_Region.Text + "', PLZ = '" + textBox_PLZ.Text + "', Land = '" + textBox_Land.Text + "', Telefon = '" + textBox_Telephon.Text
                    + "', Telefax = '" + textBox_Telefax.Text + "', Homepage = '" + textBox_Website.Text + "'  WHERE Lieferanten.[Lieferanten-Nr] = " + textBox_KundenCode.Text + ";";
                Command.ExecuteNonQuery();

                //Close the connections
                _OleDBConnection.Close();

                //Close the windows
                this.Close();
            }

            if (this._Modus == Modus.Anzeigen)
            {
                //Close the window
                this.Close();
            }
        }
    }
}
