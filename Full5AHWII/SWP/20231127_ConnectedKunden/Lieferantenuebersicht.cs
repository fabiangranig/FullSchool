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
    public partial class Lieferantenuebersicht : Form
    {
        private OleDbConnection _OleDBConnection;
        private bool _Closed;

        private List<LieferantenEintrag> Lieferanten;

        public bool ExitStatus { get { return this._Closed; } }

        public Lieferantenuebersicht(OleDbConnection oleDbConnection)
        {
            InitializeComponent();
            this._OleDBConnection = oleDbConnection;
            this._Closed = true;

            Lieferanten = new List<LieferantenEintrag>();

            //Add columns to listview
            this.listView_Lieferanten.Columns.Add("KundenCode");
            this.listView_Lieferanten.Columns[0].Width = 75;
            this.listView_Lieferanten.Columns.Add("Firma");
            this.listView_Lieferanten.Columns[1].Width = 200;
            this.listView_Lieferanten.Columns.Add("Kontaktperson");
            this.listView_Lieferanten.Columns[2].Width = 100;
            this.listView_Lieferanten.Columns.Add("Position");
            this.listView_Lieferanten.Columns[3].Width = 150;

            this.listView_Lieferanten.Columns.Add("Strasse");
            this.listView_Lieferanten.Columns[4].Width = 200;
            this.listView_Lieferanten.Columns.Add("Ort");
            this.listView_Lieferanten.Columns[5].Width = 100;
            this.listView_Lieferanten.Columns.Add("Region");
            this.listView_Lieferanten.Columns[6].Width = 100;
            this.listView_Lieferanten.Columns.Add("PLZ");
            this.listView_Lieferanten.Columns[7].Width = 100;

            this.listView_Lieferanten.Columns.Add("Land");
            this.listView_Lieferanten.Columns[8].Width = 100;
            this.listView_Lieferanten.Columns.Add("Telefon");
            this.listView_Lieferanten.Columns[9].Width = 100;
            this.listView_Lieferanten.Columns.Add("Telefax");
            this.listView_Lieferanten.Columns[10].Width = 100;

            //Get Table from Database
            GetTableFromDataBase();

            //Display from list
            DisplayFromList();
        }

        private void GetTableFromDataBase()
        {
            //Clear the list
            Lieferanten.Clear();

            //Set connection and command
            OleDbCommand command = new OleDbCommand();
            command.Connection = this._OleDBConnection;
            command.CommandText = "SELECT  * FROM LIEFERANTEN;";

            //Open connection
            this._OleDBConnection.Open();
            OleDbDataReader DataReader = command.ExecuteReader();

            //Add line by line
            while (DataReader.Read())
            {
                this.Lieferanten.Add(new LieferantenEintrag(DataReader.GetInt32(0).ToString(), DataReader.GetValue(1).ToString(), DataReader.GetValue(2).ToString(), DataReader.GetValue(3).ToString(),
                    DataReader.GetValue(4).ToString(), DataReader.GetValue(5).ToString(), DataReader.GetValue(6).ToString(), DataReader.GetValue(7).ToString(),
                    DataReader.GetValue(8).ToString(), DataReader.GetValue(9).ToString(), DataReader.GetValue(10).ToString(), DataReader.GetValue(11).ToString()));
            }

            //Close connection
            this._OleDBConnection.Close();
        }

        private void DisplayFromList()
        {
            //Clear the list
            this.listView_Lieferanten.Items.Clear();

            //Fill the listview
            for (int i = 0; i < this.Lieferanten.Count; i++)
            {
                ListViewItem LVI = new ListViewItem(new string[12] {
                    Convert.ToString(this.Lieferanten[i].Lieferanten_Nr), this.Lieferanten[i].Firma, this.Lieferanten[i].Kontaktperson,
                    this.Lieferanten[i].Position, this.Lieferanten[i].Strasse, this.Lieferanten[i].Ort,
                    this.Lieferanten[i].Region, this.Lieferanten[i].PLZ, this.Lieferanten[i].Land,
                    this.Lieferanten[i].Telefon, this.Lieferanten[i].Telefax, this.Lieferanten[i].Website});
                this.listView_Lieferanten.Items.Add(LVI);
            }
        }

        private void DisplayFromListFilter(string kundennummer, string firma, string kontaktperson)
        {
            //Clear the list
            this.listView_Lieferanten.Items.Clear();

            //Fill the listview
            for (int i = 0; i < this.Lieferanten.Count; i++)
            {
                if ((Convert.ToString(this.Lieferanten[i].Lieferanten_Nr).ToLower().Contains(textBox_LieferantenNr.Text.ToLower()) || textBox_LieferantenNr.Text == "") &&
                    (this.Lieferanten[i].Firma.ToLower().Contains(textBox_Firma.Text.ToLower()) || textBox_Firma.Text == "") &&
                    (this.Lieferanten[i].Kontaktperson.ToLower().Contains(textBox_Kontaktperson.Text.ToLower()) || textBox_Kontaktperson.Text == ""))
                {
                    ListViewItem LVI = new ListViewItem(new string[12] {
                    Convert.ToString(this.Lieferanten[i].Lieferanten_Nr), this.Lieferanten[i].Firma, this.Lieferanten[i].Kontaktperson,
                    this.Lieferanten[i].Position, this.Lieferanten[i].Strasse, this.Lieferanten[i].Ort,
                    this.Lieferanten[i].Region, this.Lieferanten[i].PLZ, this.Lieferanten[i].Land,
                    this.Lieferanten[i].Telefon, this.Lieferanten[i].Telefax, this.Lieferanten[i].Website});
                    this.listView_Lieferanten.Items.Add(LVI);
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
            DisplayFromListFilter(textBox_LieferantenNr.Text, textBox_Firma.Text, textBox_Kontaktperson.Text);
        }

        private void textBox_Firma_TextChanged(object sender, EventArgs e)
        {
            DisplayFromListFilter(textBox_LieferantenNr.Text, textBox_Firma.Text, textBox_Kontaktperson.Text);
        }

        private void textBox_Kontaktperson_TextChanged(object sender, EventArgs e)
        {
            DisplayFromListFilter(textBox_LieferantenNr.Text, textBox_Firma.Text, textBox_Kontaktperson.Text);
        }

        private void button_Neu_Click(object sender, EventArgs e)
        {
            LieferantenBearbeiten KNUB = new LieferantenBearbeiten(_OleDBConnection, Modus.Neu);
            KNUB.ShowDialog();
            GetTableFromDataBase();
            DisplayFromList();
        }

        private int GetListIDByKundenNummer()
        {
            try
            {
                ListViewItem item = this.listView_Lieferanten.Items[this.listView_Lieferanten.SelectedIndices[0]];

                //Search the master table for that entry
                for (int i = 0; i < this.Lieferanten.Count; i++)
                {
                    if (item.SubItems[0].Text == Convert.ToString(this.Lieferanten[i].Lieferanten_Nr))
                    {
                        return i;
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("kein Eintrag wurde ausgewählt! -> " + er.ToString());
                return -1;
            }
            return -1;
        }

        private void button_Aendern_Click(object sender, EventArgs e)
        {
            int id = GetListIDByKundenNummer();
            if (id != -1)
            {
                LieferantenBearbeiten KNUB = new LieferantenBearbeiten(_OleDBConnection, Modus.Aendern, this.Lieferanten[id]);
                KNUB.ShowDialog();
                GetTableFromDataBase();
                DisplayFromList();
            }
        }

        private void button_Loeschen_Click(object sender, EventArgs e)
        {
            int id = GetListIDByKundenNummer();
            if (id != -1)
            {
                //Open the connection
                _OleDBConnection.Open();

                //Set the command and execute it
                OleDbCommand Command = new OleDbCommand();
                Command.Connection = _OleDBConnection;
                Command.CommandText = "DELETE FROM Lieferanten WHERE Lieferanten.[Lieferanten-Nr] = " + this.Lieferanten[id].Lieferanten_Nr;
                Command.ExecuteNonQuery();

                //Close the connections
                _OleDBConnection.Close();

                GetTableFromDataBase();
                DisplayFromList();
            }
        }

        private void button_Anzeigen_Click(object sender, EventArgs e)
        {
            int id = GetListIDByKundenNummer();
            if (id != -1)
            {
                LieferantenBearbeiten KNUB = new LieferantenBearbeiten(_OleDBConnection, Modus.Anzeigen, this.Lieferanten[id]);
                KNUB.ShowDialog();
                GetTableFromDataBase();
                DisplayFromList();
            }
        }
    }
}
