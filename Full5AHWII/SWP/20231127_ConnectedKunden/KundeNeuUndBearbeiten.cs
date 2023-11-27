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
    public partial class KundeNeuUndBearbeiten : Form
    {
        private OleDbConnection _OleDBConnection;
        private bool _EditMode;

        public KundeNeuUndBearbeiten(OleDbConnection oleDbConnection)
        {
            InitializeComponent();
            this._OleDBConnection = oleDbConnection;
            this._EditMode = false;
        }

        public KundeNeuUndBearbeiten(OleDbConnection oleDbConnection, KundenEintrag kunden)
        {
            InitializeComponent();
            this._OleDBConnection = oleDbConnection;
            this._EditMode = true;

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
        }

        private void button_Abbrechen_Click(object sender, EventArgs e)
        {
            //Close without changing anything
            this.Close();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            //Depeding on _EditMode write result to the table
            if(this._EditMode == false)
            {
                if(textBox_KundenCode.Text != "")
                {

                }
                else
                {
                    MessageBox.Show("KundenCode is required!");
                }
            }
            else if (this._EditMode == true)
            {

            }
        }
    }
}
