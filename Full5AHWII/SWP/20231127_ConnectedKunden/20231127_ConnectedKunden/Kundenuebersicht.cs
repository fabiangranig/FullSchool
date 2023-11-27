using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20231127_ConnectedKunden
{
    public partial class Kundenuebersicht : Form
    {
        private OleDbConnection _OleDBConnection;
        private bool _Closed;

        private List<KundenEintrag> KundenEintraege;

        public bool ExitStatus { get { return this._Closed; } }

        public Kundenuebersicht(OleDbConnection oleDbConnection)
        {
            InitializeComponent();
            this._OleDBConnection = oleDbConnection;
            this._Closed = true;

            KundenEintraege = new List<KundenEintrag>();

            //Add columns to listview
            this.listView_Kunden.Columns.Add("KundenCode");
            this.listView_Kunden.Columns.Add("Firma");
            this.listView_Kunden.Columns.Add("Kontaktperson");
            this.listView_Kunden.Columns.Add("Position");

            this.listView_Kunden.Columns.Add("Strasse");
            this.listView_Kunden.Columns.Add("Ort");
            this.listView_Kunden.Columns.Add("Region");
            this.listView_Kunden.Columns.Add("PLZ");

            this.listView_Kunden.Columns.Add("Land");
            this.listView_Kunden.Columns.Add("Telefon");
            this.listView_Kunden.Columns.Add("Telefax");

            //Get Table from Database
            GetTableFromDataBase();

            //Display from list
            DisplayFromList();
        }

        private void GetTableFromDataBase()
        {
            //Clear the list
            KundenEintraege.Clear();

            //Set connection and command
            OleDbCommand command = new OleDbCommand();
            command.Connection = this._OleDBConnection;
            command.CommandText = "SELECT  * FROM KUNDEN;";

            //Open connection
            this._OleDBConnection.Open();
            OleDbDataReader DataReader = command.ExecuteReader();

            //Add line by line
            while(DataReader.Read())
            {
                this.KundenEintraege.Add(new KundenEintrag(DataReader.GetString(0), DataReader.GetString(1), DataReader.GetString(2), DataReader.GetString(3),
                    DataReader.GetString(4), DataReader.GetString(5), DataReader.GetString(6), DataReader.GetString(7),
                    DataReader.GetString(8), DataReader.GetString(9), DataReader.GetString(10)));
            }

            //Close connection
            this._OleDBConnection.Close();
        }

        private void DisplayFromList()
        {
            //Clear the list
            this.listView_Kunden.Items.Clear();

            //Fill the listview
            for(int i = 0; i < this.KundenEintraege.Count; i++)
            {
                ListViewItem LVI = new ListViewItem(new string[11] { 
                    this.KundenEintraege[i].KundenCode, this.KundenEintraege[i].Firma, this.KundenEintraege[i].Kontaktperson,
                    this.KundenEintraege[i].Position, this.KundenEintraege[i].Strasse, this.KundenEintraege[i].Ort,
                    this.KundenEintraege[i].Region, this.KundenEintraege[i].PLZ, this.KundenEintraege[i].Land,
                    this.KundenEintraege[i].Telefon, this.KundenEintraege[i].Telefax});
                this.listView_Kunden.Items.Add(LVI);
            }
        }

        private void DisplayFromListFilter(string kundennummer, string firma, string kontaktperson)
        {
            //Clear the list
            this.listView_Kunden.Items.Clear();

            //Fill the listview
            for (int i = 0; i < this.KundenEintraege.Count; i++)
            {
                if((this.KundenEintraege[i].KundenCode.ToLower().Contains(textBox_Kundennummer.Text.ToLower()) || textBox_Kundennummer.Text == "") &&
                    (this.KundenEintraege[i].Firma.ToLower().Contains(textBox_Firma.Text.ToLower()) || textBox_Firma.Text == "") &&
                    (this.KundenEintraege[i].Kontaktperson.ToLower().Contains(textBox_Kontaktperson.Text.ToLower()) || textBox_Kontaktperson.Text == ""))
                {
                    ListViewItem LVI = new ListViewItem(new string[11] {
                    this.KundenEintraege[i].KundenCode, this.KundenEintraege[i].Firma, this.KundenEintraege[i].Kontaktperson,
                    this.KundenEintraege[i].Position, this.KundenEintraege[i].Strasse, this.KundenEintraege[i].Ort,
                    this.KundenEintraege[i].Region, this.KundenEintraege[i].PLZ, this.KundenEintraege[i].Land,
                    this.KundenEintraege[i].Telefon, this.KundenEintraege[i].Telefax});
                    this.listView_Kunden.Items.Add(LVI);
                }
            }
        }

        private void button_Schliessen_Click(object sender, EventArgs e)
        {
            this._Closed = true;
            this.Close();
        }

        private void Kundenuebersicht_FormClosed(object sender, FormClosedEventArgs e)
        {
            this._Closed = true;
        }

        private void Kundenuebersicht_Load(object sender, EventArgs e)
        {
            this._Closed = false;
        }

        private void textBox_Kundennummer_TextChanged(object sender, EventArgs e)
        {
            DisplayFromListFilter(textBox_Kundennummer.Text, textBox_Firma.Text, textBox_Kontaktperson.Text);
        }

        private void textBox_Firma_TextChanged(object sender, EventArgs e)
        {
            DisplayFromListFilter(textBox_Kundennummer.Text, textBox_Firma.Text, textBox_Kontaktperson.Text);
        }

        private void textBox_Kontaktperson_TextChanged(object sender, EventArgs e)
        {
            DisplayFromListFilter(textBox_Kundennummer.Text, textBox_Firma.Text, textBox_Kontaktperson.Text);
        }
    }
}
