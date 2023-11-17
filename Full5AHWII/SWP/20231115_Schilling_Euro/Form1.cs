using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20231115_Schilling_Euro
{
    public partial class Form1 : Form
    {
        private OleDbConnection _OleDBConnection;
        private string _ConnectionString;

        public Form1()
        {
            InitializeComponent();

            //Create the connection string
            _ConnectionString = "Data Source=Euro_Datei.mdb; Provider=Microsoft.Jet.OLEDB.4.0";
            _OleDBConnection = new OleDbConnection(_ConnectionString);
        }

        private void button_Laden_Click(object sender, EventArgs e)
        {
            FileDialog FD = new OpenFileDialog();
            DialogResult result = FD.ShowDialog();

            if(result == DialogResult.OK)
            {
                ReadInDataFromFile(FD.FileName);
            }
        }

        private void ReadInDataFromFile(string File)
        {
            double korrekteSchilling = 0;
            double korrekteEuro = 0;
            double falscheSchilling = 0;
            double falscheEuro = 0;

            FileStream zeichen = new FileStream(File, FileMode.Open);
            StreamReader lesen = new StreamReader(zeichen);

            //Add columns to listview_richtigeDatensaetze
            this.listView_richtigeDatensaetze.Columns.Add("ID");
            this.listView_richtigeDatensaetze.Columns.Add("Schilling");
            this.listView_richtigeDatensaetze.Columns.Add("Euro");

            //Resize them
            this.listView_richtigeDatensaetze.Columns[0].Width = 40;
            this.listView_richtigeDatensaetze.Columns[2].Width = 100;

            //Add columns to listview_falscheDatensaetze
            this.listView_falscheDatensaetze.Columns.Add("ID");
            this.listView_falscheDatensaetze.Columns.Add("Schilling");
            this.listView_falscheDatensaetze.Columns.Add("Euro");

            //Resize them
            this.listView_falscheDatensaetze.Columns[0].Width = 40;
            this.listView_falscheDatensaetze.Columns[2].Width = 100;

            string zeilen = lesen.ReadLine();
            while (zeilen != null)
            {
                
                //Split and insert the line
                string[] split = zeilen.Split(';');
                double a1 = Convert.ToDouble(ChangePointToComma(split[1]));
                double a2 = Convert.ToDouble(ChangePointToComma(split[2]));
                if (Math.Round(a1 * 13.7603, 3) == Math.Round(a2, 3))
                {
                    korrekteSchilling += a1;
                    korrekteEuro += a2;
                    this.listView_richtigeDatensaetze.Items.Add(new ListViewItem(new string[3] { split[0], split[1], split[2] }));
                }
                else
                {
                    falscheSchilling += a1;
                    falscheEuro += a2;
                    this.listView_falscheDatensaetze.Items.Add(new ListViewItem(new string[3] { split[0], split[1], split[2] }));
                }

                //Read the lines
                zeilen = lesen.ReadLine();
            }

            lesen.Close();

            //Labels updaten
            this.label_korrekteSchillingUndEuro.Text = "Schilling: " + korrekteSchilling + " " + "Euro: " + korrekteEuro;
            this.label_falscheSchillingUndEuro.Text = "Schilling: " + falscheSchilling + " " + "Euro: " + falscheEuro;
        }

        private void button_Beenden_Click(object sender, EventArgs e)
        {
            //Close the app
            this.Close();
        }

        private void button_Speichern_Click(object sender, EventArgs e)
        {
            //Drop the tables
            DropTwoTables();

            //Create the two tables
            CreateTwoTables();

            //Fill the tables
            for(int i = 0; i < this.listView_richtigeDatensaetze.Items.Count; i++)
            {
                ListViewItem item = this.listView_richtigeDatensaetze.Items[i];
                FastExecuteNonQuery("INSERT INTO Bankomatauszug (ID, Schilling, Euro) VALUES (" + item.SubItems[0].Text + ", " + item.SubItems[1].Text + "," + item.SubItems[2].Text + ");");
            }

            for (int i = 0; i < this.listView_falscheDatensaetze.Items.Count; i++)
            {
                ListViewItem item = this.listView_falscheDatensaetze.Items[i];
                FastExecuteNonQuery("INSERT INTO AuszugFehler (ID, Schilling, Euro) VALUES (" + item.SubItems[0].Text + ", " + item.SubItems[1].Text + "," + item.SubItems[2].Text + ");");
            }
        }

        private void DropTwoTables()
        {
            try
            {
                FastExecuteNonQuery("DROP TABLE BankomatAuszug;");
            }
            catch(Exception e)
            {
                _OleDBConnection.Close();
            }
            try
            {
                FastExecuteNonQuery("DROP TABLE AuszugFehler;");
            }
            catch (Exception e)
            {
                _OleDBConnection.Close();
            }
        }

        private void CreateTwoTables()
        {
            FastExecuteNonQuery("CREATE TABLE Bankomatauszug (ID int, Schilling float, Euro float, CONSTRAINT PK_BankomatAuszug_ID PRIMARY KEY(ID))");
            FastExecuteNonQuery("CREATE TABLE Auszugfehler (ID int, Schilling float, Euro float, CONSTRAINT PK_BankomatAuszug_ID PRIMARY KEY(ID))");
        }

        private void FastExecuteNonQuery(string query)
        {
            _OleDBConnection.Open();

            OleDbCommand Command = new OleDbCommand();
            Command.Connection = _OleDBConnection;
            Command.CommandText = query;
            Command.ExecuteNonQuery();

            _OleDBConnection.Close();
        }
    }
}
